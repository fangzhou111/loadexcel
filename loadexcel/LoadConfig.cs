using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using TDGame.Scripts.ResLoad;

namespace SuperMobs.Config
{
    public interface IConfig
    {
        void Dispose();
    }

    public class ConfigBase : IConfig
    {
        private TextAsset _textAsset; 
        public virtual void Dispose()
        {
            UnloadAsset();
        }

        
        protected Stream Load(string name)
        {
            if (_textAsset == null || _textAsset.name != name)
            {
                UnloadAsset();
                var path = GetPath(name);
                _textAsset = ResLoad.LoadAsset<TextAsset>(path);
            }
            //乱写的，需要资源加载
            //TextAsset ta = UnityEditor.AssetDatabase.LoadAssetAtPath<TextAsset>("Assets/TDGameRes/config/" + name);
            // TextAsset ta = Resources.Load(name) as TextAsset;
            MemoryStream stream = new MemoryStream(_textAsset.bytes);

            return stream;
        }

        private string GetPath(string name)
        {
            return $"TDGameRes/config/{name}";
        }
        private void UnloadAsset()
        {
            if (_textAsset)
            {
                ResLoad.UnLoadAsset(GetPath(_textAsset.name));
                _textAsset = null;
            }
        }
    }

    public static class ConfigManager
    {
        private static List<IConfig> _configs = new List<IConfig>();

        public static void Add(IConfig config)
        {
            _configs.Add(config);
        }

        public static void Clear()
        {
            for (int i = 0; i < _configs.Count; i++)
            {
                _configs[i].Dispose();
                _configs.Clear();
            }
        }
    }
}

