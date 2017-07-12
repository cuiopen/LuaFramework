require "Logic/LuaClass"
require "Logic/CtrlManager"
require "Common/functions"
require "Controller/MessageCtrl"

--管理器--
MainScene = {};
local this = MainScene;

local game; 
local transform;
local gameObject;
local WWW = UnityEngine.WWW;

local PanelNames = {
    "MessagePanel",  
}

local CtrlNames = {
    MessageCtrl = MessageCtrl.New,
}

function MainScene.InitViewPanels()
	for i = 1, #PanelNames do
		require ("View/"..tostring(PanelNames[i]))
	end
end

--初始化完成，发送链接服务器信息--
function MainScene.OnInitOK()
    --注册LuaView--
    this.InitViewPanels();
    CtrlManager.Init(CtrlNames);

    local ctrl = CtrlManager.GetCtrl("MessageCtrl");
    if ctrl ~= nil and AppConst.ExampleMode == 1 then
        ctrl:Awake();
    end
       
    logWarn('LuaFramework InitOK--->>>');
end
