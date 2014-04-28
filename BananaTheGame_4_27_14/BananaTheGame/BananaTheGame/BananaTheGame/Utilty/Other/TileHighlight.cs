using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace BananaTheGame.Utilty.Other
{
    public class TileHighlight
    {
        private VertexPositionColor[] nonIndexedCube;

        private static BasicEffect highlightEffect;

        public TileHighlight()
        {

        }

        public static void Initialize()
        {
            highlightEffect = new BasicEffect(BananaGame.Graphics);
            highlightEffect.VertexColorEnabled = true;
            highlightEffect.LightingEnabled = false;
            highlightEffect.Alpha = 0.8f;
        }
    }
}
