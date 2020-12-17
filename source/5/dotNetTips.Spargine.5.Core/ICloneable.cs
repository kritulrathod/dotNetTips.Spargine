﻿// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5.Core
// Author           : David McCarter
// Created          : 11-11-2020
//
// Last Modified By : David McCarter
// Last Modified On : 11-02-2020
// ***********************************************************************
// <copyright file="ICloneable.cs" company="dotNetTips.Spargine.5.Core">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace dotNetTips.Spargine.Core
{
    /// <summary>
    /// ICloneable Interface.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    public interface ICloneable<T>
    {
        /// <summary>
        /// Cones this instance.
        /// </summary>
        /// <returns>T.</returns>
        T Cone();
    }
}