﻿#region Copyright
// <copyright file="MvxWithArgsEventToCommand.cs" company="Cirrious">
// (c) Copyright Cirrious. http://www.cirrious.com
// This source is subject to the Microsoft Public License (Ms-PL)
// Please see license.txt on http://opensource.org/licenses/ms-pl.html
// All other rights reserved.
// </copyright>
// 
// Author - Stuart Lodge, Cirrious. http://www.cirrious.com
#endregion
#warning Really need to put in a credit here to mvvmlight!

namespace Cirrious.MvvmCross.WindowsPhone.Commands
{
    public class MvxWithArgsEventToCommand : MvxEventToCommand 
    {
        public MvxWithArgsEventToCommand()
        {
            PassEventArgsToCommand = true;
        }
    }
}
