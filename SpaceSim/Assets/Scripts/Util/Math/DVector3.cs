// Type: UnityEngine.DVector3
// Assembly: UnityEngine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// Assembly location: C:\Program Files (x86)\Unity\Editor\Data\Managed\UnityEngine.dll
using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
    [Serializable]
    public struct DVector3{
        public const float kEpsilon = 1E-05f;
        public double x;
        public double y;
        public double z;

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
                    case 2:
                        return this.z;
                    default:
                        throw new IndexOutOfRangeException("Invalid index!");
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
                    case 2:
                        this.z = value;
                        break;
                    default:
                        throw new IndexOutOfRangeException("Invalid DVector3 index!");
                }
            }
        }

        public DVector3 normalized
        {
            get
            {
                return DVector3.Normalize(this);
            }
        }

        public double magnitude
        {
            get
            {
                return Math.Sqrt(this.x * this.x + this.y * this.y + this.z * this.z);
            }
        }

        public double sqrMagnitude
        {
            get
            {
                return this.x * this.x + this.y * this.y + this.z * this.z;
            }
        }

        public static DVector3 zero
        {
            get
            {
                return new DVector3(0d, 0d, 0d);
            }
        }

        public static DVector3 one
        {
            get
            {
                return new DVector3(1d, 1d, 1d);
            }
        }

        public static DVector3 forward
        {
            get
            {
                return new DVector3(0d, 0d, 1d);
            }
        }

        public static DVector3 back
        {
            get
            {
                return new DVector3(0d, 0d, -1d);
            }
        }

        public static DVector3 up
        {
            get
            {
                return new DVector3(0d, 1d, 0d);
            }
        }

        public static DVector3 down
        {
            get
            {
                return new DVector3(0d, -1d, 0d);
            }
        }

        public static DVector3 left
        {
            get
            {
                return new DVector3(-1d, 0d, 0d);
            }
        }

        public static DVector3 right
        {
            get
            {
                return new DVector3(1d, 0d, 0d);
            }
        }

        [Obsolete("Use DVector3.forward instead.")]
        public static DVector3 fwd
        {
            get
            {
                return new DVector3(0d, 0d, 1d);
            }
        }

        public DVector3(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public DVector3(float x, float y, float z)
        {
            this.x = (double)x;
            this.y = (double)y;
            this.z = (double)z;
        }

        public DVector3(Vector3 v3)
        {
            this.x = (double)v3.x;
            this.y = (double)v3.y;
            this.z = (double)v3.z;
        }

        public DVector3(double x, double y)
        {
            this.x = x;
            this.y = y;
            this.z = 0d;
        }

        public static DVector3 operator +(DVector3 a, DVector3 b)
        {
            return new DVector3(a.x + b.x, a.y + b.y, a.z + b.z);
        }

        public static DVector3 operator -(DVector3 a, DVector3 b)
        {
            return new DVector3(a.x - b.x, a.y - b.y, a.z - b.z);
        }

        public static DVector3 operator -(DVector3 a)
        {
            return new DVector3(-a.x, -a.y, -a.z);
        }

        public static DVector3 operator *(DVector3 a, double d)
        {
            return new DVector3(a.x * d, a.y * d, a.z * d);
        }

        public static DVector3 operator *(double d, DVector3 a)
        {
            return new DVector3(a.x * d, a.y * d, a.z * d);
        }

        public static DVector3 operator /(DVector3 a, double d)
        {
            return new DVector3(a.x / d, a.y / d, a.z / d);
        }

        public static bool operator ==(DVector3 lhs, DVector3 rhs)
        {
            return (double)DVector3.SqrMagnitude(lhs - rhs) < 0.0 / 1.0;
        }

        public static bool operator !=(DVector3 lhs, DVector3 rhs)
        {
            return (double)DVector3.SqrMagnitude(lhs - rhs) >= 0.0 / 1.0;
        }

        public static explicit operator Vector3(DVector3 DVector3)
        {
            return new Vector3((float)DVector3.x, (float)DVector3.y, (float)DVector3.z);
        }

        public static DVector3 Lerp(DVector3 from, DVector3 to, double t)
        {
            t = Mathd.Clamp01(t);
            return new DVector3(from.x + (to.x - from.x) * t, from.y + (to.y - from.y) * t, from.z + (to.z - from.z) * t);
        }

        public static DVector3 Slerp(DVector3 from, DVector3 to, double t)
        {
            Vector3 v3 = Vector3.Slerp((Vector3)from, (Vector3)to, (float)t);
            return new DVector3(v3);
        }

        public static void OrthoNormalize(ref DVector3 normal, ref DVector3 tangent)
        {
            Vector3 v3normal = new Vector3();
            Vector3 v3tangent = new Vector3();
            v3normal = (Vector3)normal;
            v3tangent = (Vector3)tangent;
            Vector3.OrthoNormalize(ref v3normal, ref v3tangent);
            normal = new DVector3(v3normal);
            tangent = new DVector3(v3tangent);
        }

        public static void OrthoNormalize(ref DVector3 normal, ref DVector3 tangent, ref DVector3 binormal)
        {
            Vector3 v3normal = new Vector3();
            Vector3 v3tangent = new Vector3();
            Vector3 v3binormal = new Vector3();
            v3normal = (Vector3)normal;
            v3tangent = (Vector3)tangent;
            v3binormal = (Vector3)binormal;
            Vector3.OrthoNormalize(ref v3normal, ref v3tangent, ref v3binormal);
            normal = new DVector3(v3normal);
            tangent = new DVector3(v3tangent);
            binormal = new DVector3(v3binormal);
        }

        public static DVector3 MoveTowards(DVector3 current, DVector3 target, double maxDistanceDelta)
        {
            DVector3 vector3 = target - current;
            double magnitude = vector3.magnitude;
            if (magnitude <= maxDistanceDelta || magnitude == 0.0d)
                return target;
            else
                return current + vector3 / magnitude * maxDistanceDelta;
        }

        public static DVector3 RotateTowards(DVector3 current, DVector3 target, double maxRadiansDelta, double maxMagnitudeDelta)
        {
            Vector3 v3 = Vector3.RotateTowards((Vector3)current, (Vector3)target, (float)maxRadiansDelta, (float)maxMagnitudeDelta);
            return new DVector3(v3);
        }

        public static DVector3 SmoothDamp(DVector3 current, DVector3 target, ref DVector3 currentVelocity, double smoothTime, double maxSpeed)
        {
            double deltaTime = (double)Time.deltaTime;
            return DVector3.SmoothDamp(current, target, ref currentVelocity, smoothTime, maxSpeed, deltaTime);
        }

        public static DVector3 SmoothDamp(DVector3 current, DVector3 target, ref DVector3 currentVelocity, double smoothTime)
        {
            double deltaTime = (double)Time.deltaTime;
            double maxSpeed = double.PositiveInfinity;
            return DVector3.SmoothDamp(current, target, ref currentVelocity, smoothTime, maxSpeed, deltaTime);
        }

        public static DVector3 SmoothDamp(DVector3 current, DVector3 target, ref DVector3 currentVelocity, double smoothTime, double maxSpeed, double deltaTime)
        {
            smoothTime = Mathd.Max(0.0001d, smoothTime);
            double num1 = 2d / smoothTime;
            double num2 = num1 * deltaTime;
            double num3 = (1.0d / (1.0d + num2 + 0.479999989271164d * num2 * num2 + 0.234999999403954d * num2 * num2 * num2));
            DVector3 vector = current - target;
            DVector3 vector3_1 = target;
            double maxLength = maxSpeed * smoothTime;
            DVector3 vector3_2 = DVector3.ClampMagnitude(vector, maxLength);
            target = current - vector3_2;
            DVector3 vector3_3 = (currentVelocity + num1 * vector3_2) * deltaTime;
            currentVelocity = (currentVelocity - num1 * vector3_3) * num3;
            DVector3 vector3_4 = target + (vector3_2 + vector3_3) * num3;
            if (DVector3.Dot(vector3_1 - current, vector3_4 - vector3_1) > 0.0)
            {
                vector3_4 = vector3_1;
                currentVelocity = (vector3_4 - vector3_1) / deltaTime;
            }
            return vector3_4;
        }

        public void Set(double new_x, double new_y, double new_z)
        {
            this.x = new_x;
            this.y = new_y;
            this.z = new_z;
        }

        public static DVector3 Scale(DVector3 a, DVector3 b)
        {
            return new DVector3(a.x * b.x, a.y * b.y, a.z * b.z);
        }

        public void Scale(DVector3 scale)
        {
            this.x *= scale.x;
            this.y *= scale.y;
            this.z *= scale.z;
        }

        public static DVector3 Cross(DVector3 lhs, DVector3 rhs)
        {
            return new DVector3(lhs.y * rhs.z - lhs.z * rhs.y, lhs.z * rhs.x - lhs.x * rhs.z, lhs.x * rhs.y - lhs.y * rhs.x);
        }

        public override int GetHashCode()
        {
            return this.x.GetHashCode() ^ this.y.GetHashCode() << 2 ^ this.z.GetHashCode() >> 2;
        }

        public override bool Equals(object other)
        {
            if (!(other is DVector3))
                return false;
            DVector3 DVector3 = (DVector3)other;
            if (this.x.Equals(DVector3.x) && this.y.Equals(DVector3.y))
                return this.z.Equals(DVector3.z);
            else
                return false;
        }

        public static DVector3 Reflect(DVector3 inDirection, DVector3 inNormal)
        {
            return -2d * DVector3.Dot(inNormal, inDirection) * inNormal + inDirection;
        }

        public static DVector3 Normalize(DVector3 value)
        {
            double num = DVector3.Magnitude(value);
            if (num > 9.99999974737875E-06)
                return value / num;
            else
                return DVector3.zero;
        }

        public void Normalize()
        {
            double num = DVector3.Magnitude(this);
            if (num > 9.99999974737875E-06)
                this = this / num;
            else
                this = DVector3.zero;
        }
        // TODO : fix formatting
        public override string ToString()
        {
            return "(" + this.x + " - " + this.y + " - " + this.z + ")";
        }

        public static double Dot(DVector3 lhs, DVector3 rhs)
        {
            return lhs.x * rhs.x + lhs.y * rhs.y + lhs.z * rhs.z;
        }

        public static DVector3 Project(DVector3 vector, DVector3 onNormal)
        {
            double num = DVector3.Dot(onNormal, onNormal);
            if (num < 1.40129846432482E-45d)
                return DVector3.zero;
            else
                return onNormal * DVector3.Dot(vector, onNormal) / num;
        }

        public static DVector3 Exclude(DVector3 excludeThis, DVector3 fromThat)
        {
            return fromThat - DVector3.Project(fromThat, excludeThis);
        }

        public static double Angle(DVector3 from, DVector3 to)
        {
            return Mathd.Acos(Mathd.Clamp(DVector3.Dot(from.normalized, to.normalized), -1d, 1d)) * 57.29578d;
        }

        public static double Distance(DVector3 a, DVector3 b)
        {
            DVector3 DVector3 = new DVector3(a.x - b.x, a.y - b.y, a.z - b.z);
            return Math.Sqrt(DVector3.x * DVector3.x + DVector3.y * DVector3.y + DVector3.z * DVector3.z);
        }

        public static DVector3 ClampMagnitude(DVector3 vector, double maxLength)
        {
            if (vector.sqrMagnitude > maxLength * maxLength)
                return vector.normalized * maxLength;
            else
                return vector;
        }

        public static double Magnitude(DVector3 a)
        {
            return Math.Sqrt(a.x * a.x + a.y * a.y + a.z * a.z);
        }

        public static double SqrMagnitude(DVector3 a)
        {
            return a.x * a.x + a.y * a.y + a.z * a.z;
        }

        public static DVector3 Min(DVector3 lhs, DVector3 rhs)
        {
            return new DVector3(Mathd.Min(lhs.x, rhs.x), Mathd.Min(lhs.y, rhs.y), Mathd.Min(lhs.z, rhs.z));
        }

        public static DVector3 Max(DVector3 lhs, DVector3 rhs)
        {
            return new DVector3(Mathd.Max(lhs.x, rhs.x), Mathd.Max(lhs.y, rhs.y), Mathd.Max(lhs.z, rhs.z));
        }

        [Obsolete("Use DVector3.Angle instead. AngleBetween uses radians instead of degrees and was deprecated for this reason")]
        public static double AngleBetween(DVector3 from, DVector3 to)
        {
            return Mathd.Acos(Mathd.Clamp(DVector3.Dot(from.normalized, to.normalized), -1d, 1d));
        }
    }
}