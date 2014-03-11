﻿using System;
using System.Collections.Generic;
using Wise.Framework.Interface.DependencyInjection.Enum;

namespace Wise.Framework.Interface.DependencyInjection
{
    /// <summary>
    /// Interface used to describe Dependency injection container
    /// </summary>
    public interface IContainer : IDisposable
    {
        void Teardown(object o);
        object Configure(Type configurationInterface);
        void RegisterTypeIfMissing<T1, T2>(LifetimeScope lifetimeScope) where T2 : T1;
        bool IsTypeRegistered<T1>();
        T1 Resolve<T1>();
        T1 Resolve<T1>(string name);
        object Resolve(Type d);
        object Resolve(Type d, string name);
        void RegisterInstance<T1>(T1 instance);
        void RegisterInstance<T1>(T1 instance, string name);

        IContainer CreateChildContainer();
        IContainer RemoveAllExtensions();
        IContainer AddExtension(object extension);

        IEnumerable<IContainerRegistration> Registrations { get; }
        IContainer RegisterType(Type from, Type to, string name, object lifetimeManager, object[] injectionMembers);
        IContainer RegisterInstance(Type t, string name, object instance, object lifetime);

    }
}
