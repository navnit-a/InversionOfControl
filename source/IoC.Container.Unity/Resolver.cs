using System;
using System.Collections.Generic;
using System.Linq;

namespace IoC.Container.Unity
{
    public class Resolver
    {
        private readonly Dictionary<Type, Type> _dependencyMap = new Dictionary<Type, Type>();

        public T Resolve<T>()
        {
            return (T) Resolve(typeof(T));
        }

        private object Resolve(Type typeToResolve)
        {
            Type resolvedType;
            try
            {
                resolvedType = _dependencyMap[typeToResolve];
            }
            catch (Exception)
            {
                throw new Exception(string.Format("Could not resolve type :: {0}", typeToResolve.FullName));
            }

            var firstConstructor = resolvedType.GetConstructors().First();
            var constructorParameters = firstConstructor.GetParameters();
            if (constructorParameters.Length == 0)
            {
                return Activator.CreateInstance(resolvedType);
            }

            IList<object> parameters = new List<object>();
            foreach (var parameterToResolve in constructorParameters)
            {
                parameters.Add(Resolve(parameterToResolve.ParameterType));
            }

            return firstConstructor.Invoke(parameters.ToArray());
        }

        public void Register<TFrom, TTo>()
        {
            _dependencyMap.Add(typeof(TFrom), typeof(TTo));
        }
    }
}