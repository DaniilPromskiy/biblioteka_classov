﻿using System;

namespace PromskiyDaniil_CatFramework
{
    public class CatException : ArgumentException
    {
        public CatException(string message) : base(message) { }
    }
}