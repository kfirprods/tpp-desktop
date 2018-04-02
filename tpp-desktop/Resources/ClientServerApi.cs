// **********************************************************************
//
// Copyright (c) 2003-2013 ZeroC, Inc. All rights reserved.
//
// This copy of Ice is licensed to you under the terms described in the
// ICE_LICENSE file included in this distribution.
//
// **********************************************************************
//
// Ice version 3.5.1
//
// <auto-generated>
//
// Generated from file `ClientServerApi.ice'
//
// Warning: do not edit this file.
//
// </auto-generated>
//


using _System = global::System;
using _Microsoft = global::Microsoft;

#pragma warning disable 1591

namespace IceCompactId
{
}

namespace main
{
    [_System.Runtime.InteropServices.ComVisible(false)]
    [_System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704")]
    [_System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707")]
    [_System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709")]
    [_System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710")]
    [_System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1711")]
    [_System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1715")]
    [_System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1716")]
    [_System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1720")]
    [_System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1722")]
    [_System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1724")]
    public partial interface GuiOperations : Ice.Object, GuiOperationsOperations_, GuiOperationsOperationsNC_
    {
    }

    [_System.Runtime.InteropServices.ComVisible(false)]
    [_System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704")]
    [_System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707")]
    [_System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709")]
    [_System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710")]
    [_System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1711")]
    [_System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1715")]
    [_System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1716")]
    [_System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1720")]
    [_System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1722")]
    [_System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1724")]
    public partial interface Plugin : Ice.Object, PluginOperations_, PluginOperationsNC_
    {
    }
}

namespace main
{
    [_System.CodeDom.Compiler.GeneratedCodeAttribute("slice2cs", "3.5.1")]
    public delegate void Callback_GuiOperations_ShowMessageBox();

    [_System.CodeDom.Compiler.GeneratedCodeAttribute("slice2cs", "3.5.1")]
    public delegate void Callback_Plugin_execute();
}

namespace main
{
    [_System.CodeDom.Compiler.GeneratedCodeAttribute("slice2cs", "3.5.1")]
    public interface GuiOperationsPrx : Ice.ObjectPrx
    {
        void ShowMessageBox(string text);
        void ShowMessageBox(string text, _System.Collections.Generic.Dictionary<string, string> context__);

        Ice.AsyncResult<main.Callback_GuiOperations_ShowMessageBox> begin_ShowMessageBox(string text);
        Ice.AsyncResult<main.Callback_GuiOperations_ShowMessageBox> begin_ShowMessageBox(string text, _System.Collections.Generic.Dictionary<string, string> ctx__);

        Ice.AsyncResult begin_ShowMessageBox(string text, Ice.AsyncCallback cb__, object cookie__);
        Ice.AsyncResult begin_ShowMessageBox(string text, _System.Collections.Generic.Dictionary<string, string> ctx__, Ice.AsyncCallback cb__, object cookie__);

        void end_ShowMessageBox(Ice.AsyncResult r__);
    }

    [_System.CodeDom.Compiler.GeneratedCodeAttribute("slice2cs", "3.5.1")]
    public interface PluginPrx : Ice.ObjectPrx
    {
        void execute(string[] files);
        void execute(string[] files, _System.Collections.Generic.Dictionary<string, string> context__);

        Ice.AsyncResult<main.Callback_Plugin_execute> begin_execute(string[] files);
        Ice.AsyncResult<main.Callback_Plugin_execute> begin_execute(string[] files, _System.Collections.Generic.Dictionary<string, string> ctx__);

        Ice.AsyncResult begin_execute(string[] files, Ice.AsyncCallback cb__, object cookie__);
        Ice.AsyncResult begin_execute(string[] files, _System.Collections.Generic.Dictionary<string, string> ctx__, Ice.AsyncCallback cb__, object cookie__);

        void end_execute(Ice.AsyncResult r__);
    }
}

namespace main
{
    [_System.CodeDom.Compiler.GeneratedCodeAttribute("slice2cs", "3.5.1")]
    public interface GuiOperationsOperations_
    {
        void ShowMessageBox(string text, Ice.Current current__);
    }

    [_System.CodeDom.Compiler.GeneratedCodeAttribute("slice2cs", "3.5.1")]
    public interface GuiOperationsOperationsNC_
    {
        void ShowMessageBox(string text);
    }

    [_System.CodeDom.Compiler.GeneratedCodeAttribute("slice2cs", "3.5.1")]
    public interface PluginOperations_
    {
        void execute(string[] files, Ice.Current current__);
    }

    [_System.CodeDom.Compiler.GeneratedCodeAttribute("slice2cs", "3.5.1")]
    public interface PluginOperationsNC_
    {
        void execute(string[] files);
    }
}

namespace main
{
    [_System.Runtime.InteropServices.ComVisible(false)]
    [_System.CodeDom.Compiler.GeneratedCodeAttribute("slice2cs", "3.5.1")]
    public sealed class GuiOperationsPrxHelper : Ice.ObjectPrxHelperBase, GuiOperationsPrx
    {
        #region Synchronous operations

        public void ShowMessageBox(string text)
        {
            ShowMessageBox(text, null, false);
        }

        public void ShowMessageBox(string text, _System.Collections.Generic.Dictionary<string, string> context__)
        {
            ShowMessageBox(text, context__, true);
        }

        private void ShowMessageBox(string text, _System.Collections.Generic.Dictionary<string, string> context__, bool explicitContext__)
        {
            if(explicitContext__ && context__ == null)
            {
                context__ = emptyContext_;
            }
            Ice.Instrumentation.InvocationObserver observer__ = IceInternal.ObserverHelper.get(this, __ShowMessageBox_name, context__);
            int cnt__ = 0;
            try
            {
                while(true)
                {
                    Ice.ObjectDel_ delBase__ = null;
                    try
                    {
                        delBase__ = getDelegate__(false);
                        GuiOperationsDel_ del__ = (GuiOperationsDel_)delBase__;
                        del__.ShowMessageBox(text, context__, observer__);
                        return;
                    }
                    catch(IceInternal.LocalExceptionWrapper ex__)
                    {
                        handleExceptionWrapper__(delBase__, ex__, observer__);
                    }
                    catch(Ice.LocalException ex__)
                    {
                        handleException__(delBase__, ex__, true, ref cnt__, observer__);
                    }
                }
            }
            finally
            {
                if(observer__ != null)
                {
                    observer__.detach();
                }
            }
        }

        #endregion

        #region Asynchronous operations

        public Ice.AsyncResult<main.Callback_GuiOperations_ShowMessageBox> begin_ShowMessageBox(string text)
        {
            return begin_ShowMessageBox(text, null, false, null, null);
        }

        public Ice.AsyncResult<main.Callback_GuiOperations_ShowMessageBox> begin_ShowMessageBox(string text, _System.Collections.Generic.Dictionary<string, string> ctx__)
        {
            return begin_ShowMessageBox(text, ctx__, true, null, null);
        }

        public Ice.AsyncResult begin_ShowMessageBox(string text, Ice.AsyncCallback cb__, object cookie__)
        {
            return begin_ShowMessageBox(text, null, false, cb__, cookie__);
        }

        public Ice.AsyncResult begin_ShowMessageBox(string text, _System.Collections.Generic.Dictionary<string, string> ctx__, Ice.AsyncCallback cb__, object cookie__)
        {
            return begin_ShowMessageBox(text, ctx__, true, cb__, cookie__);
        }

        private const string __ShowMessageBox_name = "ShowMessageBox";

        public void end_ShowMessageBox(Ice.AsyncResult r__)
        {
            end__(r__, __ShowMessageBox_name);
        }

        private Ice.AsyncResult<main.Callback_GuiOperations_ShowMessageBox> begin_ShowMessageBox(string text, _System.Collections.Generic.Dictionary<string, string> ctx__, bool explicitContext__, Ice.AsyncCallback cb__, object cookie__)
        {
            IceInternal.OnewayOutgoingAsync<main.Callback_GuiOperations_ShowMessageBox> result__ = new IceInternal.OnewayOutgoingAsync<main.Callback_GuiOperations_ShowMessageBox>(this, __ShowMessageBox_name, ShowMessageBox_completed__, cookie__);
            if(cb__ != null)
            {
                result__.whenCompletedWithAsyncCallback(cb__);
            }
            try
            {
                result__.prepare__(__ShowMessageBox_name, Ice.OperationMode.Normal, ctx__, explicitContext__);
                IceInternal.BasicStream os__ = result__.startWriteParams__(Ice.FormatType.DefaultFormat);
                os__.writeString(text);
                result__.endWriteParams__();
                result__.send__(true);
            }
            catch(Ice.LocalException ex__)
            {
                result__.exceptionAsync__(ex__);
            }
            return result__;
        }

        private void ShowMessageBox_completed__(main.Callback_GuiOperations_ShowMessageBox cb__)
        {
            if(cb__ != null)
            {
                cb__();
            }
        }

        #endregion

        #region Checked and unchecked cast operations

        public static GuiOperationsPrx checkedCast(Ice.ObjectPrx b)
        {
            if(b == null)
            {
                return null;
            }
            GuiOperationsPrx r = b as GuiOperationsPrx;
            if((r == null) && b.ice_isA(ice_staticId()))
            {
                GuiOperationsPrxHelper h = new GuiOperationsPrxHelper();
                h.copyFrom__(b);
                r = h;
            }
            return r;
        }

        public static GuiOperationsPrx checkedCast(Ice.ObjectPrx b, _System.Collections.Generic.Dictionary<string, string> ctx)
        {
            if(b == null)
            {
                return null;
            }
            GuiOperationsPrx r = b as GuiOperationsPrx;
            if((r == null) && b.ice_isA(ice_staticId(), ctx))
            {
                GuiOperationsPrxHelper h = new GuiOperationsPrxHelper();
                h.copyFrom__(b);
                r = h;
            }
            return r;
        }

        public static GuiOperationsPrx checkedCast(Ice.ObjectPrx b, string f)
        {
            if(b == null)
            {
                return null;
            }
            Ice.ObjectPrx bb = b.ice_facet(f);
            try
            {
                if(bb.ice_isA(ice_staticId()))
                {
                    GuiOperationsPrxHelper h = new GuiOperationsPrxHelper();
                    h.copyFrom__(bb);
                    return h;
                }
            }
            catch(Ice.FacetNotExistException)
            {
            }
            return null;
        }

        public static GuiOperationsPrx checkedCast(Ice.ObjectPrx b, string f, _System.Collections.Generic.Dictionary<string, string> ctx)
        {
            if(b == null)
            {
                return null;
            }
            Ice.ObjectPrx bb = b.ice_facet(f);
            try
            {
                if(bb.ice_isA(ice_staticId(), ctx))
                {
                    GuiOperationsPrxHelper h = new GuiOperationsPrxHelper();
                    h.copyFrom__(bb);
                    return h;
                }
            }
            catch(Ice.FacetNotExistException)
            {
            }
            return null;
        }

        public static GuiOperationsPrx uncheckedCast(Ice.ObjectPrx b)
        {
            if(b == null)
            {
                return null;
            }
            GuiOperationsPrx r = b as GuiOperationsPrx;
            if(r == null)
            {
                GuiOperationsPrxHelper h = new GuiOperationsPrxHelper();
                h.copyFrom__(b);
                r = h;
            }
            return r;
        }

        public static GuiOperationsPrx uncheckedCast(Ice.ObjectPrx b, string f)
        {
            if(b == null)
            {
                return null;
            }
            Ice.ObjectPrx bb = b.ice_facet(f);
            GuiOperationsPrxHelper h = new GuiOperationsPrxHelper();
            h.copyFrom__(bb);
            return h;
        }

        public static readonly string[] ids__ =
        {
            "::Ice::Object",
            "::main::GuiOperations"
        };

        public static string ice_staticId()
        {
            return ids__[1];
        }

        #endregion

        #region Marshaling support

        protected override Ice.ObjectDelM_ createDelegateM__()
        {
            return new GuiOperationsDelM_();
        }

        protected override Ice.ObjectDelD_ createDelegateD__()
        {
            return new GuiOperationsDelD_();
        }

        public static void write__(IceInternal.BasicStream os__, GuiOperationsPrx v__)
        {
            os__.writeProxy(v__);
        }

        public static GuiOperationsPrx read__(IceInternal.BasicStream is__)
        {
            Ice.ObjectPrx proxy = is__.readProxy();
            if(proxy != null)
            {
                GuiOperationsPrxHelper result = new GuiOperationsPrxHelper();
                result.copyFrom__(proxy);
                return result;
            }
            return null;
        }

        #endregion
    }

    [_System.CodeDom.Compiler.GeneratedCodeAttribute("slice2cs", "3.5.1")]
    public sealed class StringArrayHelper
    {
        public static void write(IceInternal.BasicStream os__, string[] v__)
        {
            os__.writeStringSeq(v__);
        }

        public static string[] read(IceInternal.BasicStream is__)
        {
            string[] v__;
            v__ = is__.readStringSeq();
            return v__;
        }
    }

    [_System.Runtime.InteropServices.ComVisible(false)]
    [_System.CodeDom.Compiler.GeneratedCodeAttribute("slice2cs", "3.5.1")]
    public sealed class PluginPrxHelper : Ice.ObjectPrxHelperBase, PluginPrx
    {
        #region Synchronous operations

        public void execute(string[] files)
        {
            execute(files, null, false);
        }

        public void execute(string[] files, _System.Collections.Generic.Dictionary<string, string> context__)
        {
            execute(files, context__, true);
        }

        private void execute(string[] files, _System.Collections.Generic.Dictionary<string, string> context__, bool explicitContext__)
        {
            if(explicitContext__ && context__ == null)
            {
                context__ = emptyContext_;
            }
            Ice.Instrumentation.InvocationObserver observer__ = IceInternal.ObserverHelper.get(this, __execute_name, context__);
            int cnt__ = 0;
            try
            {
                while(true)
                {
                    Ice.ObjectDel_ delBase__ = null;
                    try
                    {
                        delBase__ = getDelegate__(false);
                        PluginDel_ del__ = (PluginDel_)delBase__;
                        del__.execute(files, context__, observer__);
                        return;
                    }
                    catch(IceInternal.LocalExceptionWrapper ex__)
                    {
                        handleExceptionWrapper__(delBase__, ex__, observer__);
                    }
                    catch(Ice.LocalException ex__)
                    {
                        handleException__(delBase__, ex__, true, ref cnt__, observer__);
                    }
                }
            }
            finally
            {
                if(observer__ != null)
                {
                    observer__.detach();
                }
            }
        }

        #endregion

        #region Asynchronous operations

        public Ice.AsyncResult<main.Callback_Plugin_execute> begin_execute(string[] files)
        {
            return begin_execute(files, null, false, null, null);
        }

        public Ice.AsyncResult<main.Callback_Plugin_execute> begin_execute(string[] files, _System.Collections.Generic.Dictionary<string, string> ctx__)
        {
            return begin_execute(files, ctx__, true, null, null);
        }

        public Ice.AsyncResult begin_execute(string[] files, Ice.AsyncCallback cb__, object cookie__)
        {
            return begin_execute(files, null, false, cb__, cookie__);
        }

        public Ice.AsyncResult begin_execute(string[] files, _System.Collections.Generic.Dictionary<string, string> ctx__, Ice.AsyncCallback cb__, object cookie__)
        {
            return begin_execute(files, ctx__, true, cb__, cookie__);
        }

        private const string __execute_name = "execute";

        public void end_execute(Ice.AsyncResult r__)
        {
            end__(r__, __execute_name);
        }

        private Ice.AsyncResult<main.Callback_Plugin_execute> begin_execute(string[] files, _System.Collections.Generic.Dictionary<string, string> ctx__, bool explicitContext__, Ice.AsyncCallback cb__, object cookie__)
        {
            IceInternal.OnewayOutgoingAsync<main.Callback_Plugin_execute> result__ = new IceInternal.OnewayOutgoingAsync<main.Callback_Plugin_execute>(this, __execute_name, execute_completed__, cookie__);
            if(cb__ != null)
            {
                result__.whenCompletedWithAsyncCallback(cb__);
            }
            try
            {
                result__.prepare__(__execute_name, Ice.OperationMode.Normal, ctx__, explicitContext__);
                IceInternal.BasicStream os__ = result__.startWriteParams__(Ice.FormatType.DefaultFormat);
                main.StringArrayHelper.write(os__, files);
                result__.endWriteParams__();
                result__.send__(true);
            }
            catch(Ice.LocalException ex__)
            {
                result__.exceptionAsync__(ex__);
            }
            return result__;
        }

        private void execute_completed__(main.Callback_Plugin_execute cb__)
        {
            if(cb__ != null)
            {
                cb__();
            }
        }

        #endregion

        #region Checked and unchecked cast operations

        public static PluginPrx checkedCast(Ice.ObjectPrx b)
        {
            if(b == null)
            {
                return null;
            }
            PluginPrx r = b as PluginPrx;
            if((r == null) && b.ice_isA(ice_staticId()))
            {
                PluginPrxHelper h = new PluginPrxHelper();
                h.copyFrom__(b);
                r = h;
            }
            return r;
        }

        public static PluginPrx checkedCast(Ice.ObjectPrx b, _System.Collections.Generic.Dictionary<string, string> ctx)
        {
            if(b == null)
            {
                return null;
            }
            PluginPrx r = b as PluginPrx;
            if((r == null) && b.ice_isA(ice_staticId(), ctx))
            {
                PluginPrxHelper h = new PluginPrxHelper();
                h.copyFrom__(b);
                r = h;
            }
            return r;
        }

        public static PluginPrx checkedCast(Ice.ObjectPrx b, string f)
        {
            if(b == null)
            {
                return null;
            }
            Ice.ObjectPrx bb = b.ice_facet(f);
            try
            {
                if(bb.ice_isA(ice_staticId()))
                {
                    PluginPrxHelper h = new PluginPrxHelper();
                    h.copyFrom__(bb);
                    return h;
                }
            }
            catch(Ice.FacetNotExistException)
            {
            }
            return null;
        }

        public static PluginPrx checkedCast(Ice.ObjectPrx b, string f, _System.Collections.Generic.Dictionary<string, string> ctx)
        {
            if(b == null)
            {
                return null;
            }
            Ice.ObjectPrx bb = b.ice_facet(f);
            try
            {
                if(bb.ice_isA(ice_staticId(), ctx))
                {
                    PluginPrxHelper h = new PluginPrxHelper();
                    h.copyFrom__(bb);
                    return h;
                }
            }
            catch(Ice.FacetNotExistException)
            {
            }
            return null;
        }

        public static PluginPrx uncheckedCast(Ice.ObjectPrx b)
        {
            if(b == null)
            {
                return null;
            }
            PluginPrx r = b as PluginPrx;
            if(r == null)
            {
                PluginPrxHelper h = new PluginPrxHelper();
                h.copyFrom__(b);
                r = h;
            }
            return r;
        }

        public static PluginPrx uncheckedCast(Ice.ObjectPrx b, string f)
        {
            if(b == null)
            {
                return null;
            }
            Ice.ObjectPrx bb = b.ice_facet(f);
            PluginPrxHelper h = new PluginPrxHelper();
            h.copyFrom__(bb);
            return h;
        }

        public static readonly string[] ids__ =
        {
            "::Ice::Object",
            "::main::Plugin"
        };

        public static string ice_staticId()
        {
            return ids__[1];
        }

        #endregion

        #region Marshaling support

        protected override Ice.ObjectDelM_ createDelegateM__()
        {
            return new PluginDelM_();
        }

        protected override Ice.ObjectDelD_ createDelegateD__()
        {
            return new PluginDelD_();
        }

        public static void write__(IceInternal.BasicStream os__, PluginPrx v__)
        {
            os__.writeProxy(v__);
        }

        public static PluginPrx read__(IceInternal.BasicStream is__)
        {
            Ice.ObjectPrx proxy = is__.readProxy();
            if(proxy != null)
            {
                PluginPrxHelper result = new PluginPrxHelper();
                result.copyFrom__(proxy);
                return result;
            }
            return null;
        }

        #endregion
    }
}

namespace main
{
    [_System.CodeDom.Compiler.GeneratedCodeAttribute("slice2cs", "3.5.1")]
    public interface GuiOperationsDel_ : Ice.ObjectDel_
    {
        void ShowMessageBox(string text, _System.Collections.Generic.Dictionary<string, string> context__, Ice.Instrumentation.InvocationObserver observer__);
    }

    [_System.CodeDom.Compiler.GeneratedCodeAttribute("slice2cs", "3.5.1")]
    public interface PluginDel_ : Ice.ObjectDel_
    {
        void execute(string[] files, _System.Collections.Generic.Dictionary<string, string> context__, Ice.Instrumentation.InvocationObserver observer__);
    }
}

namespace main
{
    [_System.Runtime.InteropServices.ComVisible(false)]
    [_System.CodeDom.Compiler.GeneratedCodeAttribute("slice2cs", "3.5.1")]
    public sealed class GuiOperationsDelM_ : Ice.ObjectDelM_, GuiOperationsDel_
    {
        public void ShowMessageBox(string text, _System.Collections.Generic.Dictionary<string, string> context__, Ice.Instrumentation.InvocationObserver observer__)
        {
            IceInternal.Outgoing og__ = handler__.getOutgoing("ShowMessageBox", Ice.OperationMode.Normal, context__, observer__);
            try
            {
                try
                {
                    IceInternal.BasicStream os__ = og__.startWriteParams(Ice.FormatType.DefaultFormat);
                    os__.writeString(text);
                    og__.endWriteParams();
                }
                catch(Ice.LocalException ex__)
                {
                    og__.abort(ex__);
                }
                bool ok__ = og__.invoke();
                if(og__.hasResponse())
                {
                    try
                    {
                        if(!ok__)
                        {
                            try
                            {
                                og__.throwUserException();
                            }
                            catch(Ice.UserException ex__)
                            {
                                throw new Ice.UnknownUserException(ex__.ice_name(), ex__);
                            }
                        }
                        og__.readEmptyParams();
                    }
                    catch(Ice.LocalException ex__)
                    {
                        throw new IceInternal.LocalExceptionWrapper(ex__, false);
                    }
                }
            }
            finally
            {
                handler__.reclaimOutgoing(og__);
            }
        }
    }

    [_System.Runtime.InteropServices.ComVisible(false)]
    [_System.CodeDom.Compiler.GeneratedCodeAttribute("slice2cs", "3.5.1")]
    public sealed class PluginDelM_ : Ice.ObjectDelM_, PluginDel_
    {
        public void execute(string[] files, _System.Collections.Generic.Dictionary<string, string> context__, Ice.Instrumentation.InvocationObserver observer__)
        {
            IceInternal.Outgoing og__ = handler__.getOutgoing("execute", Ice.OperationMode.Normal, context__, observer__);
            try
            {
                try
                {
                    IceInternal.BasicStream os__ = og__.startWriteParams(Ice.FormatType.DefaultFormat);
                    main.StringArrayHelper.write(os__, files);
                    og__.endWriteParams();
                }
                catch(Ice.LocalException ex__)
                {
                    og__.abort(ex__);
                }
                bool ok__ = og__.invoke();
                if(og__.hasResponse())
                {
                    try
                    {
                        if(!ok__)
                        {
                            try
                            {
                                og__.throwUserException();
                            }
                            catch(Ice.UserException ex__)
                            {
                                throw new Ice.UnknownUserException(ex__.ice_name(), ex__);
                            }
                        }
                        og__.readEmptyParams();
                    }
                    catch(Ice.LocalException ex__)
                    {
                        throw new IceInternal.LocalExceptionWrapper(ex__, false);
                    }
                }
            }
            finally
            {
                handler__.reclaimOutgoing(og__);
            }
        }
    }
}

namespace main
{
    [_System.Runtime.InteropServices.ComVisible(false)]
    [_System.CodeDom.Compiler.GeneratedCodeAttribute("slice2cs", "3.5.1")]
    public sealed class GuiOperationsDelD_ : Ice.ObjectDelD_, GuiOperationsDel_
    {
        [_System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031")]
        public void ShowMessageBox(string text, _System.Collections.Generic.Dictionary<string, string> context__, Ice.Instrumentation.InvocationObserver observer__)
        {
            Ice.Current current__ = new Ice.Current();
            initCurrent__(ref current__, "ShowMessageBox", Ice.OperationMode.Normal, context__);
            IceInternal.Direct.RunDelegate run__ = delegate(Ice.Object obj__)
            {
                GuiOperations servant__ = null;
                try
                {
                    servant__ = (GuiOperations)obj__;
                }
                catch(_System.InvalidCastException)
                {
                    throw new Ice.OperationNotExistException(current__.id, current__.facet, current__.operation);
                }
                servant__.ShowMessageBox(text, current__);
                return Ice.DispatchStatus.DispatchOK;
            };
            IceInternal.Direct direct__ = null;
            try
            {
                direct__ = new IceInternal.Direct(current__, run__);
                try
                {
                    Ice.DispatchStatus status__ = direct__.getServant().collocDispatch__(direct__);
                    _System.Diagnostics.Debug.Assert(status__ == Ice.DispatchStatus.DispatchOK);
                }
                finally
                {
                    direct__.destroy();
                }
            }
            catch(Ice.SystemException)
            {
                throw;
            }
            catch(_System.Exception ex__)
            {
                IceInternal.LocalExceptionWrapper.throwWrapper(ex__);
            }
        }
    }

    [_System.Runtime.InteropServices.ComVisible(false)]
    [_System.CodeDom.Compiler.GeneratedCodeAttribute("slice2cs", "3.5.1")]
    public sealed class PluginDelD_ : Ice.ObjectDelD_, PluginDel_
    {
        [_System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031")]
        public void execute(string[] files, _System.Collections.Generic.Dictionary<string, string> context__, Ice.Instrumentation.InvocationObserver observer__)
        {
            Ice.Current current__ = new Ice.Current();
            initCurrent__(ref current__, "execute", Ice.OperationMode.Normal, context__);
            IceInternal.Direct.RunDelegate run__ = delegate(Ice.Object obj__)
            {
                Plugin servant__ = null;
                try
                {
                    servant__ = (Plugin)obj__;
                }
                catch(_System.InvalidCastException)
                {
                    throw new Ice.OperationNotExistException(current__.id, current__.facet, current__.operation);
                }
                servant__.execute(files, current__);
                return Ice.DispatchStatus.DispatchOK;
            };
            IceInternal.Direct direct__ = null;
            try
            {
                direct__ = new IceInternal.Direct(current__, run__);
                try
                {
                    Ice.DispatchStatus status__ = direct__.getServant().collocDispatch__(direct__);
                    _System.Diagnostics.Debug.Assert(status__ == Ice.DispatchStatus.DispatchOK);
                }
                finally
                {
                    direct__.destroy();
                }
            }
            catch(Ice.SystemException)
            {
                throw;
            }
            catch(_System.Exception ex__)
            {
                IceInternal.LocalExceptionWrapper.throwWrapper(ex__);
            }
        }
    }
}

namespace main
{
    [_System.Runtime.InteropServices.ComVisible(false)]
    [_System.CodeDom.Compiler.GeneratedCodeAttribute("slice2cs", "3.5.1")]
    public abstract class GuiOperationsDisp_ : Ice.ObjectImpl, GuiOperations
    {
        #region Slice operations

        public void ShowMessageBox(string text)
        {
            ShowMessageBox(text, Ice.ObjectImpl.defaultCurrent);
        }

        public abstract void ShowMessageBox(string text, Ice.Current current__);

        #endregion

        #region Slice type-related members

        public static new readonly string[] ids__ = 
        {
            "::Ice::Object",
            "::main::GuiOperations"
        };

        public override bool ice_isA(string s)
        {
            return _System.Array.BinarySearch(ids__, s, IceUtilInternal.StringUtil.OrdinalStringComparer) >= 0;
        }

        public override bool ice_isA(string s, Ice.Current current__)
        {
            return _System.Array.BinarySearch(ids__, s, IceUtilInternal.StringUtil.OrdinalStringComparer) >= 0;
        }

        public override string[] ice_ids()
        {
            return ids__;
        }

        public override string[] ice_ids(Ice.Current current__)
        {
            return ids__;
        }

        public override string ice_id()
        {
            return ids__[1];
        }

        public override string ice_id(Ice.Current current__)
        {
            return ids__[1];
        }

        public static new string ice_staticId()
        {
            return ids__[1];
        }

        #endregion

        #region Operation dispatch

        [_System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
        public static Ice.DispatchStatus ShowMessageBox___(GuiOperations obj__, IceInternal.Incoming inS__, Ice.Current current__)
        {
            checkMode__(Ice.OperationMode.Normal, current__.mode);
            IceInternal.BasicStream is__ = inS__.startReadParams();
            string text;
            text = is__.readString();
            inS__.endReadParams();
            obj__.ShowMessageBox(text, current__);
            inS__.writeEmptyParams__();
            return Ice.DispatchStatus.DispatchOK;
        }

        private static string[] all__ =
        {
            "ShowMessageBox",
            "ice_id",
            "ice_ids",
            "ice_isA",
            "ice_ping"
        };

        public override Ice.DispatchStatus dispatch__(IceInternal.Incoming inS__, Ice.Current current__)
        {
            int pos = _System.Array.BinarySearch(all__, current__.operation, IceUtilInternal.StringUtil.OrdinalStringComparer);
            if(pos < 0)
            {
                throw new Ice.OperationNotExistException(current__.id, current__.facet, current__.operation);
            }

            switch(pos)
            {
                case 0:
                {
                    return ShowMessageBox___(this, inS__, current__);
                }
                case 1:
                {
                    return ice_id___(this, inS__, current__);
                }
                case 2:
                {
                    return ice_ids___(this, inS__, current__);
                }
                case 3:
                {
                    return ice_isA___(this, inS__, current__);
                }
                case 4:
                {
                    return ice_ping___(this, inS__, current__);
                }
            }

            _System.Diagnostics.Debug.Assert(false);
            throw new Ice.OperationNotExistException(current__.id, current__.facet, current__.operation);
        }

        #endregion

        #region Marshaling support

        protected override void writeImpl__(IceInternal.BasicStream os__)
        {
            os__.startWriteSlice(ice_staticId(), -1, true);
            os__.endWriteSlice();
        }

        protected override void readImpl__(IceInternal.BasicStream is__)
        {
            is__.startReadSlice();
            is__.endReadSlice();
        }

        #endregion
    }

    [_System.Runtime.InteropServices.ComVisible(false)]
    [_System.CodeDom.Compiler.GeneratedCodeAttribute("slice2cs", "3.5.1")]
    public abstract class PluginDisp_ : Ice.ObjectImpl, Plugin
    {
        #region Slice operations

        public void execute(string[] files)
        {
            execute(files, Ice.ObjectImpl.defaultCurrent);
        }

        public abstract void execute(string[] files, Ice.Current current__);

        #endregion

        #region Slice type-related members

        public static new readonly string[] ids__ = 
        {
            "::Ice::Object",
            "::main::Plugin"
        };

        public override bool ice_isA(string s)
        {
            return _System.Array.BinarySearch(ids__, s, IceUtilInternal.StringUtil.OrdinalStringComparer) >= 0;
        }

        public override bool ice_isA(string s, Ice.Current current__)
        {
            return _System.Array.BinarySearch(ids__, s, IceUtilInternal.StringUtil.OrdinalStringComparer) >= 0;
        }

        public override string[] ice_ids()
        {
            return ids__;
        }

        public override string[] ice_ids(Ice.Current current__)
        {
            return ids__;
        }

        public override string ice_id()
        {
            return ids__[1];
        }

        public override string ice_id(Ice.Current current__)
        {
            return ids__[1];
        }

        public static new string ice_staticId()
        {
            return ids__[1];
        }

        #endregion

        #region Operation dispatch

        [_System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
        public static Ice.DispatchStatus execute___(Plugin obj__, IceInternal.Incoming inS__, Ice.Current current__)
        {
            checkMode__(Ice.OperationMode.Normal, current__.mode);
            IceInternal.BasicStream is__ = inS__.startReadParams();
            string[] files;
            files = main.StringArrayHelper.read(is__);
            inS__.endReadParams();
            obj__.execute(files, current__);
            inS__.writeEmptyParams__();
            return Ice.DispatchStatus.DispatchOK;
        }

        private static string[] all__ =
        {
            "execute",
            "ice_id",
            "ice_ids",
            "ice_isA",
            "ice_ping"
        };

        public override Ice.DispatchStatus dispatch__(IceInternal.Incoming inS__, Ice.Current current__)
        {
            int pos = _System.Array.BinarySearch(all__, current__.operation, IceUtilInternal.StringUtil.OrdinalStringComparer);
            if(pos < 0)
            {
                throw new Ice.OperationNotExistException(current__.id, current__.facet, current__.operation);
            }

            switch(pos)
            {
                case 0:
                {
                    return execute___(this, inS__, current__);
                }
                case 1:
                {
                    return ice_id___(this, inS__, current__);
                }
                case 2:
                {
                    return ice_ids___(this, inS__, current__);
                }
                case 3:
                {
                    return ice_isA___(this, inS__, current__);
                }
                case 4:
                {
                    return ice_ping___(this, inS__, current__);
                }
            }

            _System.Diagnostics.Debug.Assert(false);
            throw new Ice.OperationNotExistException(current__.id, current__.facet, current__.operation);
        }

        #endregion

        #region Marshaling support

        protected override void writeImpl__(IceInternal.BasicStream os__)
        {
            os__.startWriteSlice(ice_staticId(), -1, true);
            os__.endWriteSlice();
        }

        protected override void readImpl__(IceInternal.BasicStream is__)
        {
            is__.startReadSlice();
            is__.endReadSlice();
        }

        #endregion
    }
}
