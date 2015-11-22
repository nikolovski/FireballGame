using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Resources;
using Proektna__prototip.Properties;

namespace Proektna__prototip
{
    /// <summary>
    /// 
    /// </summary>
    class Ball
    {
        public float positionX { get; set; }
        public float positionY { get; set; }
        public float ballRadius { get; set; }
        public float angle { get; set; }
        public Rectangle bound;
        public float directionX;
        public float directionY;
        public float nextPositionX;
        public float nextPositionY;
        public int speed;
        Image ballGraphics;
        ResourceManager rm = Resources.ResourceManager;

        /// <summary>
        /// Main constructor
        /// </summary>
        /// <param name="positionX">Position of the ball on x-axis</param>
        /// <param name="positionY">Position of the ball on y-axis</param>
        /// <param name="ballRadius">The size of the ball</param>
        /// <param name="speed">The constant speed</param>
        /// <param name="angle">Controls the direction of the ball's movement</param>
        public Ball(float positionX, float positionY, float ballRadius, int speed, float angle){
            this.positionX = positionX;
            this.positionY = positionY;
            this.speed = speed;
            this.ballRadius = ballRadius;
            this.angle = angle;
            directionX = (float)Math.Cos(angle);
            directionY = (float)Math.Sin(angle);
        }
        
        public void move(){
            //Determining the next ball's coordinates
             nextPositionX = positionX + directionX;
             nextPositionY = positionY + directionY;

            //Condition for bouncing of the top and bottom boundaries
            if (nextPositionY - ballRadius <= bound.Top || (nextPositionY + ballRadius >= bound.Bottom)){
                directionY = -directionY;
            }
             positionX += directionX * speed; //Velocity on x-axis
             positionY += directionY * speed; //Velocity on y-axis
        }

        public void Draw(Brush brush, Graphics g){
            
            //IV quadrant to II quadrant
            if ((Math.Abs(directionY) > directionY + 1) && (Math.Abs(directionX) > directionX + 1)){
                  ballGraphics = (Image)rm.GetObject("topce_1");
              }
            //II quadrant to IV quadrant
            else if (Math.Abs(directionX) > directionX + 1){
                ballGraphics = (Image)rm.GetObject("topce_3");
            }
            //III quadrant to I quadrant
            else if (Math.Abs(directionY) > directionY + 1){
                ballGraphics = (Image)rm.GetObject("topce_4");
            }
            //I quadrant to III quadrant
            else{
                ballGraphics = (Image)rm.GetObject("topce_2");   
            }
            g.DrawImage(ballGraphics, positionX - ballRadius, positionY - ballRadius);
        }
    } 
}
