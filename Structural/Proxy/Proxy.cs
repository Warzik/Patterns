﻿using Proxy.Abstraction;
using System;

namespace Proxy
{
    public class Proxy : ISubject
    {
        private readonly RealSubject _realSubject;

        public Proxy(RealSubject realSubject)
        {
            _realSubject = realSubject;
        }

        public void Request()
        {
            if (CheckAccess())
            {
                _realSubject.Request();

                LogAccess();
            }
        }

        public static bool CheckAccess()
        {
            Console.WriteLine("Proxy: Checking access prior to firing a real request.");

            return true;
        }

        public static void LogAccess()
        {
            Console.WriteLine("Proxy: Logging the time of request.");
        }
    }
}