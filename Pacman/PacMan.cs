﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Pacman
{
    public class PacMan
    {
        private Rectangle rect;
        private int xSpeed, ySpeed;
        private int lives;

        public PacMan(int _x, int _y, int _size, int _xSpeed, int _ySpeed, int _lives)
        {
            rect.X = _x;
            rect.Y = _y;
            rect.Width = _size;
            rect.Height = _size;
            xSpeed = _xSpeed;
            ySpeed = _ySpeed;
            lives = _lives;
        }

        public void move()
        {
            rect.X += xSpeed;
            rect.Y += ySpeed;
        }

        public void move(int _xSpeed, int _ySpeed)
        {
            rect.X += _xSpeed;
            rect.Y += _ySpeed;
        }

        public void setSpeed(int _xSpeed, int _ySpeed)
        {
            xSpeed += _xSpeed;
            ySpeed += _ySpeed;
        }

        public void setPosition(int _x, int _y)
        {
            rect.X = _x;
            rect.Y = _y;
        }

        bool collision()
        {
            // TODO: Collision with pellets and ghosts
            return false;
        }
    }
}