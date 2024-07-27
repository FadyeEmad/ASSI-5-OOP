using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSI_5_OOP
{
    internal class point : IComparable
    {
        int x, y, z;

        public point()
        {

        }
        public point(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public override string ToString()
        {
            return $"(  {x} ,  {y} , {z} ) ";
        }
        public void settwopoint(int X, int Y)
        {
            x = X;
            y = Y;
        }

        public int CompareTo(object? obj)
        {
            point p = (point)obj;

                if (this.x > p.x && this.y > p.y)
                {
                    return 1;
                }
                else if (this.x < p.x && this.y < p.y)
                {
                    return -1;
                }
                else {
                    return 0;
                            }
            }
        } 
    }

