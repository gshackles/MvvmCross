#region Copyright
// <copyright file="MvxBindingTouchViewController.cs" company="Cirrious">
// (c) Copyright Cirrious. http://www.cirrious.com
// This source is subject to the Microsoft Public License (Ms-PL)
// Please see license.txt on http://opensource.org/licenses/ms-pl.html
// All other rights reserved.
// </copyright>
// 
// Project Lead - Stuart Lodge, Cirrious. http://www.cirrious.com
#endregion

using System.Collections.Generic;
using Cirrious.MvvmCross.Binding.Interfaces;
using Cirrious.MvvmCross.Binding.Touch.ExtensionMethods;
using Cirrious.MvvmCross.Binding.Touch.Interfaces;
using Cirrious.MvvmCross.Interfaces.ViewModels;
using Cirrious.MvvmCross.Touch.Views;
using Cirrious.MvvmCross.Views;
using MonoTouch.Foundation;

namespace Cirrious.MvvmCross.Binding.Touch.Views
{
    public class MvxBindingTouchViewController<TViewModel>
        : MvxTouchViewController<TViewModel>
        , IMvxBindingTouchView 
        where TViewModel : class, IMvxViewModel
    {
        protected MvxBindingTouchViewController(MvxShowViewModelRequest request) 
            : base(request)
        {
        }

        protected MvxBindingTouchViewController(MvxShowViewModelRequest request, string nibName, NSBundle bundle) 
            : base(request, nibName, bundle)
        {
        }

        #region Shared area needed by all binding controllers

        private readonly List<IMvxUpdateableBinding> _bindings = new List<IMvxUpdateableBinding>();
        public List<IMvxUpdateableBinding> Bindings
        {
            get { return _bindings; }
        }

        public virtual object DefaultBindingSource { get { return ViewModel; } }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                this.ClearBindings();
            }

            base.Dispose(disposing);
        }

        public override void ViewDidUnload()
        {
            this.ClearBindings();
            base.ViewDidUnload();
        }

        #endregion
    }
}