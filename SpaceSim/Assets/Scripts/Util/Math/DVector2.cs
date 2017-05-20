// Type: UnityEngine.Vector2
// Assembly: UnityEngine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// Assembly location: C:\Program Files (x86)\Unity\Editor\Data\Managed\UnityEngine.dll
using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
    public struct DVector2
    {
        public const double kEpsilon = 1E-05d;
        public double x;
        public double y;

        public double this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0:
                        return this.x;
                    case 1:
                        return this.y;
                    default:
                        throw new IndexOutOfRangeException("Invalid DVector2 index!");
                }
            }
            set
            {
                switch (index)
                {
                    case 0:
                        this.x = value;
                        break;
                    case 1:
                        this.y = value;
                        break;
                    default:
                        throw new IndexOutOfRangeException("Invalid DVector2 index!");
                }
            }
        }

        public DVector2 normalized
        {
            get
            {
                DVector2 DVector2 = new DVector2(this.x, this.y);
                DVector2.Normalize();
                return DVector2;
            }
        }

        public double magnitude
        {
            get
            {
                return Mathd.Sqrt(this.x * this.x + this.y * this.y);
            }
        }

        public double sqrMagnitude
        {
            get
            {
                return this.x * this.x + this.y * this.y;
            }
        }

        public static DVector2 zero
        {
            get
            {
                return new DVector2(0.0d, 0.0d);
            }
        }

        public static DVector2 one
        {
            get
            {
                return new DVector2(1d, 1d);
            }
        }

        public static DVector2 up
        {
            get
            {
                return new DVector2(0.0d, 1d);
            }
        }

        public static DVector2 right
        {
            get
            {
                return new DVector2(1d, 0.0d);
            }
        }

        public DVector2(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public static implicit operator DVector2(DVector3 v)
        {
            return new DVector2(v.x, v.y);
        }

        public static implicit operator DVector3(DVector2 v)
        {
            return new DVector3(v.x, v.y, 0.0d);
        }

        public static DVector2 operator +(DVector2 a, DVector2 b)
        {
            return new DVector2(a.x + b.x, a.y + b.y);
        }

        public static DVector2 operator -(DVector2 a, DVector2 b)
        {
            return new DVector2(a.x - b.x, a.y - b.y);
        }

        public static DVector2 operator -(DVector2 a)
        {
            return new DVector2(-a.x, -a.y);
        }

        public static DVector2 operator *(DVector2 a, double d)
        {
            return new DVector2(a.x * d, a.y * d);
        }

        public static DVector2 operator *(float d, DVector2 a)
        {
            return new DVector2(a.x * d, a.y * d);
        }

        public static DVector2 operator /(DVector2 a, double d)
        {
            return new DVector2(a.x / d, a.y / d);
        }

        public static bool operator ==(DVector2 lhs, DVector2 rhs)
        {
            return DVector2.SqrMagnitude(lhs - rhs) < 0.0 / 1.0;
        }

        public static bool operator !=(DVector2 lhs, DVector2 rhs)
        {
            return (double)DVector2.SqrMagnitude(lhs - rhs) >= 0.0 / 1.0;
        }

        public void Set(double new_x, double new_y)
        {
            this.x = new_x;
            this.y = new_y;
        }

        public static DVector2 Lerp(DVector2 from, DVector2 to, double t)
        {
            t = Mathd.Clamp01(t);
            return new DVector2(from.x + (to.x - from.x) * t, from.y + (to.y - from.y) * t);
        }

        public static DVector2 MoveTowards(DVector2 current, DVector2 target, double maxDistanceDelta)
        {
            DVector2 vector2 = target - current;
            double magnitude = vector2.magnitude;
            if (magnitude <= maxDistanceDelta || magnitude == 0.0d)
                return target;
            else
                return current + vector2 / magnitude * maxDistanceDelta;
        }

        public static DVector2 Scale(DVector2 a, DVector2 b)
        {
            return new DVector2(a.x * b.x, a.y * b.y);
        }

        public void Scale(DVector2 scale)
        {
            this.x *= scale.x;
            this.y *= scale.y;
        }

        public void Normalize()
        {
            double magnitude = this.magnitude;
            if (magnitude > 9.99999974737875E-06)
                this = this / magnitude;
            else
                this = DVector2.zero;
        }

        public override string ToString()
        {
            /*
      string fmt = "({0:D1}, {1:D1})";
      object[] objArray = new object[2];
      int index1 = 0;
      // ISSUE: variable of a boxed type
      __Boxed<double> local1 = (ValueType) this.x;
      objArray[index1] = (object) local1;
      int index2 = 1;
      // ISSUE: variable of a boxed type
      __Boxed<double> local2 = (ValueType) this.y;
      objArray[index2] = (object) local2;
      */
            return "not implemented";
        }

        public string ToString(string format)
        {
            /* TODO:
      string fmt = "({0}, {1})";
      object[] objArray = new object[2];
      int index1 = 0;
      string str1 = this.x.ToString(format);
      objArray[index1] = (object) str1;
      int index2 = 1;
      string str2 = this.y.ToString(format);
      objArray[index2] = (object) str2;
      */
            return "not implemented";
        }

        public override int GetHashCode()
        {
            return this.x.GetHashCode() ^ this.y.GetHashCode() << 2;
        }

        public override bool Equals(object other)
        {
            if (!(other is DVector2))
                return false;
            DVector2 DVector2 = (DVector2)other;
            if (this.x.Equals(DVector2.x))
                return this.y.Equals(DVector2.y);
            else
                return false;
        }

        public static double Dot(DVector2 lhs, DVector2 rhs)
        {
            return lhs.x * rhs.x + lhs.y * rhs.y;
        }

        public static double Angle(DVector2 from, DVector2 to)
        {
            return Mathd.Acos(Mathd.Clamp(DVector2.Dot(from.normalized, to.normalized), -1d, 1d)) * 57.29578d;
        }

        public static double Distance(DVector2 a, DVector2 b)
        {
            return (a - b).magnitude;
        }

        public static DVector2 ClampMagnitude(DVector2 vector, double maxLength)
        {
            if (vector.sqrMagnitude > maxLength * maxLength)
                return vector.normalized * maxLength;
            else
                return vector;
        }

        public static double SqrMagnitude(DVector2 a)
        {
            return (a.x * a.x + a.y * a.y);
        }

        public double SqrMagnitude()
        {
            return (this.x * this.x + this.y * this.y);
        }

        public static DVector2 Min(DVector2 lhs, DVector2 rhs)
        {
            return new DVector2(Mathd.Min(lhs.x, rhs.x), Mathd.Min(lhs.y, rhs.y));
        }

        public static DVector2 Max(DVector2 lhs, DVector2 rhs)
        {
            return new DVector2(Mathd.Max(lhs.x, rhs.x), Mathd.Max(lhs.y, rhs.y));
        }
    }
}