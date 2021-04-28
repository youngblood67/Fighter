using Fighter.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fighter.Technical
{
    public class AssetHandler
    {
        /// <summary>
        /// SINGLETON permettant de gérer les assets
        /// </summary>
        private AssetHandler() { }

        private static AssetHandler _instance;

        public static AssetHandler GetInstance()
        {
            if (_instance == null)
            {
                _instance = new AssetHandler();
            }
            return _instance;
        }

        /// Business logic

        public void Move(Ship asset, Direction direction)
        {
            asset.Move(asset, direction);
        }

        public void Rotate(Ship asset, Sens sens)
        {
            asset.Rotate(asset, sens);
        }




    }
}
