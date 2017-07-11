require "Logic/LuaClass"
require "Logic/CtrlManager"
require "Common/functions"
require "Controller/PromptCtrl"

--管理器--
LoginScene = {};
local this = LoginScene;

local game; 
local transform;
local gameObject;
local WWW = UnityEngine.WWW;

function LoginScene.InitViewPanels()
	for i = 1, #PanelNames do
		require ("View/"..tostring(PanelNames[i]))
	end
end

--初始化完成，发送链接服务器信息--
function LoginScene.OnInitOK()
    --注册LuaView--
    this.InitViewPanels();
    CtrlManager.Init();
    local ctrl = CtrlManager.GetCtrl(CtrlNames.Prompt);
    if ctrl ~= nil and AppConst.ExampleMode == 1 then
        ctrl:Awake();
    end
       
    logWarn('LuaFramework InitOK--->>>');
end
