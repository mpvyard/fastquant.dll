﻿using System;
using System.Drawing;

namespace SmartQuant.FinChart.Objects
{
    public class DrawingRectangle : IUpdatable
    {
        private int wigth = 1;
        private DateTime x1;
        private DateTime x2;
        private double y1;
        private double y2;
        private bool rangeY;
        private Color color;

        public bool RangeY
        {
            get
            {
                return this.rangeY;
            }
            set
            {
                this.rangeY = value;
                EmitUpdated();
            }
        }

        public Color Color
        {
            get
            {
                return this.color;
            }
            set
            {
                this.color = value;
                EmitUpdated();
            }
        }

        public int Width
        {
            get
            {
                return this.wigth;
            }
            set
            {
                this.wigth = value;
                EmitUpdated();
            }
        }

        public string Name { get; }

        public DateTime X1
        {
            get
            {
                return this.x1;
            }
            set
            {
                this.x1 = value;
                EmitUpdated();
            }
        }

        public DateTime X2
        {
            get
            {
                return this.x2;
            }
            set
            {
                this.x2 = value;
                EmitUpdated();
            }
        }

        public double Y1
        {
            get
            {
                return this.y1;
            }
            set
            {
                this.y1 = value;
                EmitUpdated();
            }
        }

        public double Y2
        {
            get
            {
                return this.y2;
            }
            set
            {
                this.y2 = value;
                EmitUpdated();
            }
        }

        public event EventHandler Updated;

        public DrawingRectangle(DateTime x1, double y1, DateTime x2, double y2, string name)
        {
            Name = name;
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
        }

        private void EmitUpdated() => Updated?.Invoke(this, EventArgs.Empty);
    }
}
