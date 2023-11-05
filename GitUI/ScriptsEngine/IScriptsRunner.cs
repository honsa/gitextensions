﻿using GitUIPluginInterfaces;
using ResourceManager;

namespace GitUI.ScriptsEngine
{
    public interface IScriptsRunner
    {
        bool RunEventScripts<THostForm>(ScriptEvent scriptEvent, THostForm form)
            where THostForm : IGitModuleForm, IWin32Window;

        bool RunScript(int scriptId, IWin32Window owner, IGitUICommands commands, IScriptOptionsProvider? scriptOptionsProvider = null);
    }
}
