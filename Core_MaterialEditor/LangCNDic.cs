using System;
using System.Collections.Generic;

namespace KK_Plugins {
    class LangCNDic
    {
        public static BepInEx.Logging.ManualLogSource Logger;

        private const string Statement = "本插件由PopChicken@ZOD汉化，若有修改意愿请前往Github clone";

        protected readonly static Dictionary<string, string> En2CnDic = new Dictionary<string, string>()
        {
            {"open image", "打开图片"},
            {"material editor", "材质编辑器"},
            {"renderer", "渲染器"},
            {"enabled", "启用"},
            {"shadowcastingmode", "阴影投射(ShadowCastingMode)"},
            {"renderqueue", "渲染队列(RenderQueue)"},
            {"twosided", "两侧"},
            {"shadowsonly", "仅阴影"},
            {"receiveshadows", "接收阴影(ReceiveShadows)"},
            {"material", "材质"},
            {"shader", "着色器"},
            {"reset", "重置"},
            {"import texture", "导入贴图"},
            {"export texture", "导出贴图"},
            {"shaderrenderqueue", "着色器渲染队列(ShaderRenderQueue)"},
            {"r", "R"},
            {"g", "G"},
            {"b", "B"},
            {"a", "A"},
            {"no texture", "无贴图"},
            {"offset x", "X偏移(Offset X)"},
            {"y", "Y"},
            {"scale x", "X坐标(Scale X)"},
            {"on", "打开"},
            {"off", "关闭"},
            {"open material editor", "打开材质编辑器"},
            {"open material editor (body)", "打开材质编辑器(身体)"},
            {"open material editor (face)", "打开材质编辑器(脸部)"},
            {"open material editor (all)", "打开材质编辑器(整体)"},
            {"open material editor (back)", "打开材质编辑器(后发)"},
            {"open material editor (front)", "打开材质编辑器(前发)"},
            {"open material editor (side)", "打开材质编辑器(侧发)"},
            {"open material editor (extension)", "打开材质编辑器(接发)"},
            {"open material editor (top)", "打开材质编辑器(上衣)"},
            {"open material editor (bottom)", "打开材质编辑器(下衣)"},
            {"open material editor (bra)", "打开材质编辑器(胸衣)"},
            {"open material editor (underwear)", "打开材质编辑器(胖次)"},
            {"open material editor (gloves)", "打开材质编辑器(手套)"},
            {"open material editor (pantyhose)", "打开材质编辑器(裤袜)"},
            {"open material editor (socks)", "打开材质编辑器(袜子)"},
            {"open material editor (shoes)", "打开材质编辑器(鞋子)"},
            {"export uv map", "导出UV贴图映射(Export UV Map)"},
            {"export .obj", "导出.obj文件"},
        };

        public static string Trans2CN(string s)
        {
            if (s.IsNullOrEmpty()) return "";

            Logger.LogInfo($"[{MaterialEditor.PluginNameInternal}]尝试翻译\"{s}\"");
            int pos = s.IndexOf(':');

            if (pos == -1) pos = s.Length;
            string _s = s.Substring(0, pos);

            if (En2CnDic.ContainsKey(_s.ToLower()) && En2CnDic[_s.ToLower()].Length > 0) {
                Logger.LogDebug($"[{MaterialEditor.PluginNameInternal}]找到片段\"{_s}\"的对应翻译\"{En2CnDic[_s.ToLower()]}\"");
                return En2CnDic[_s.ToLower()] + s.Substring(pos);
            }
            else {
                Logger.LogDebug($"[{MaterialEditor.PluginNameInternal}]未找到片段\"{_s}\"的对应翻译" );
                return s;
            }
        }
    }
}

// rend.NameFormatted()
// materialName
// shaderName
// LabelText(ColorDefault())
// LabelText(defaultValue)
//  labelOffsetScaleText()
//  LabelText(FloatDefault())