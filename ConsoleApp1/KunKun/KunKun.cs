using GameTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shard
{
    class KunKun : Game, InputListener
    {
        private Character character;
        private Background background;
        private Ground ground;
        private Subsidence subsidence;
        public override void update()
        {

            Bootstrap.getDisplay().showText("FPS: " + Bootstrap.getSecondFPS() + " / " + Bootstrap.getFPS(), 10, 10, 12, 255, 255, 255);

        }
        public override int getTargetFrameRate()
        {
            return 60;

        }

        public override void initialize()
        {
            background = new Background();
            character = new Character();


            
            Ground ground1 = new Ground();
            ground1.Transform.X = 0; // 起始位置
            ground1.Transform.Y = 933.0f; // 统一的垂直位置
            ground1.Transform.Scalex = 0.21f; // 第一部分的宽度
            ground1.Transform.Scaley = 0.5f; // 地面的厚度


            Subsidence subsidence1 = new Subsidence();
            subsidence1.Transform.X = 300; // 起始位置
            subsidence1.Transform.Y = 950.0f; // 统一的垂直位置
            subsidence1.Transform.Scalex = 0.5f; // 第二部分的宽度
            subsidence1.Transform.Scaley = 0.5f; // 地面的厚度

            Pillar pillar1 = new Pillar();
            pillar1.Transform.X = 250;
            pillar1.Transform.Y = 850.0f;
            pillar1.Transform.Scalex = 1;
            pillar1.Transform.Scaley = 1;
            Bootstrap.getInput().addListener(this);
        }


        public void handleInput(InputEvent inp, string eventType)
        {
            character.handleInput(background, inp, eventType);

        }

    }
}
