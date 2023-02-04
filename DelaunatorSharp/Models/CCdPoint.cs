using System;
using System.Collections.Generic;
using System.Text;

namespace DelaunatorSharp.Models
{
   /// <summary>
   /// 기존 Point에 고도값이나, 기타 정보를 포함하기 위해서.
   /// </summary>
	public struct CCdPoint : IPoint
   {
      public double X { get; set; }
      public double Y { get; set; }
      public object tag { get; set; }

      public CCdPoint(double x, double y, object userTag = null )
      {
         X = x;
         Y = y;
         this.tag = userTag;
      }
      public override string ToString() => $"{X},{Y}";
   }
}
