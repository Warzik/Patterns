﻿using Proxy.Abstraction;
using System;

namespace Proxy
{
    public class RealSubject : ISubject
    {
        public void Request()
        {
            Console.WriteLine("RealSubject: Handling Request.");
        }
    }
}