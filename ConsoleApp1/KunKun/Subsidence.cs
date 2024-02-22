using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shard
{
    internal class Subsidence: GameObject, CollisionHandler
    {
        public Subsidence()
        {

            this.Transform.SpritePath = Bootstrap.getAssetManager().getAssetPath("subsidence.png");

            setPhysicsEnabled();


            MyBody.Mass = 10000;
            MyBody.MaxForce = 0;
            MyBody.Drag = 0f;
            MyBody.UsesGravity = false;
            MyBody.StopOnCollision = true;


            MyBody.addRectCollider();

            addTag("Subsidence");
        }



        public override void update()
        {
            Bootstrap.getDisplay().addToDraw(this);
        }

        public void onCollisionEnter(PhysicsBody x)
        {

        }

        public void onCollisionExit(PhysicsBody x)
        {

        }

        public void onCollisionStay(PhysicsBody x)
        {

        }

    }

}
