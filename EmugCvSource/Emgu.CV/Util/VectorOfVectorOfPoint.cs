﻿//----------------------------------------------------------------------------
//
//  Copyright (C) 2004-2020 by EMGU Corporation. All rights reserved.
//
//  Vector of VectorOfPoint
//
//  This file is automatically generated, do not modify.
//----------------------------------------------------------------------------



using System;
using System.Drawing;
using System.Diagnostics;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using Emgu.CV.Structure;

namespace Emgu.CV.Util
{
   /// <summary>
   /// Wrapped class of the C++ standard vector of VectorOfPoint.
   /// </summary>
   [Serializable]
   [DebuggerTypeProxy(typeof(VectorOfVectorOfPoint.DebuggerProxy))]
   public partial class VectorOfVectorOfPoint : Emgu.Util.UnmanagedObject, IInputOutputArray
   {
      private readonly bool _needDispose;
   
      static VectorOfVectorOfPoint()
      {
         CvInvoke.CheckLibraryLoaded();
      }

      /// <summary>
      /// Create an empty standard vector of VectorOfPoint
      /// </summary>
      public VectorOfVectorOfPoint()
         : this(VectorOfVectorOfPointCreate(), true)
      {
      }
	  
      internal VectorOfVectorOfPoint(IntPtr ptr, bool needDispose)
      {
         _ptr = ptr;
         _needDispose = needDispose;
      }

      /// <summary>
      /// Create an standard vector of VectorOfPoint of the specific size
      /// </summary>
      /// <param name="size">The size of the vector</param>
      public VectorOfVectorOfPoint(int size)
         : this( VectorOfVectorOfPointCreateSize(size), true)
      {
      }
	  
      /// <summary>
      /// Create an standard vector of VectorOfPoint with the initial values
      /// </summary>
      /// <param name="values">The initial values</param>
	  public VectorOfVectorOfPoint(params VectorOfPoint[] values)
	    : this()
	  {
        Push(values);
	  }

      /// <summary>
      /// Get the size of the vector
      /// </summary>
      public int Size
      {
         get
         {
            return VectorOfVectorOfPointGetSize(_ptr);
         }
      }

      /// <summary>
      /// Clear the vector
      /// </summary>
      public void Clear()
      {
         VectorOfVectorOfPointClear(_ptr);
      }
	  
	   /// <summary>
      /// Push a value into the standard vector
      /// </summary>
      /// <param name="value">The value to be pushed to the vector</param>
      public void Push(VectorOfPoint value)
      {
         VectorOfVectorOfPointPush(_ptr, value.Ptr);
      }

      /// <summary>
      /// Push multiple values into the standard vector
      /// </summary>
      /// <param name="values">The values to be pushed to the vector</param>
      public void Push(VectorOfPoint[] values)
      {
         foreach (VectorOfPoint value in values)
            Push(value);
      }

      /// <summary>
      /// Push multiple values from the other vector into this vector
      /// </summary>
      /// <param name="other">The other vector, from which the values will be pushed to the current vector</param>
      public void Push(VectorOfVectorOfPoint other)
      {
         VectorOfVectorOfPointPushVector(_ptr, other);
      }
      
	   /// <summary>
      /// Get the item in the specific index
      /// </summary>
      /// <param name="index">The index</param>
      /// <returns>The item in the specific index</returns>
      public VectorOfPoint this[int index]
      {
         get
         {
		    IntPtr itemPtr = IntPtr.Zero;
            VectorOfVectorOfPointGetItemPtr(_ptr, index, ref itemPtr);
            return new VectorOfPoint(itemPtr, false);
         }
      }

      /// <summary>
      /// Release the standard vector
      /// </summary>
      protected override void DisposeObject()
      {
         if (_needDispose && _ptr != IntPtr.Zero)
            VectorOfVectorOfPointRelease(ref _ptr);
      }

      /// <summary>
      /// Get the pointer to cv::_InputArray
      /// </summary>
      /// <returns>The input array</returns>
      public InputArray GetInputArray()
      {
        return new InputArray( cveInputArrayFromVectorOfVectorOfPoint(_ptr), this );
      }
	  
      /// <summary>
      /// Get the pointer to cv::_OutputArray
      /// </summary>
      /// <returns>The output array</returns>
      public OutputArray GetOutputArray()
      {
         return new OutputArray( cveOutputArrayFromVectorOfVectorOfPoint(_ptr), this );
      }

      /// <summary>
      /// Get the pointer to cv::_InputOutputArray
      /// </summary>
      /// <returns>The input output array</returns>
      public InputOutputArray GetInputOutputArray()
      {
         return new InputOutputArray( cveInputOutputArrayFromVectorOfVectorOfPoint(_ptr), this );
      }     
      
      /// <summary>
      /// The size of the item in this Vector, counted as size in bytes.
      /// </summary>
      public static int SizeOfItemInBytes
      {
         get { return VectorOfVectorOfPointSizeOfItemInBytes(); }
      }

#if true
      /// <summary>
      /// Create the standard vector of VectorOfPoint 
      /// </summary>
      public VectorOfVectorOfPoint(Point[][] values)
         : this()
      {
         using (VectorOfPoint v = new VectorOfPoint())
         {
            for (int i = 0; i < values.Length; i++)
            {
               v.Push(values[i]);
               Push(v);
               v.Clear();
            }
         }
      }
	  
	   /// <summary>
      /// Convert the standard vector to arrays of int
      /// </summary>
      /// <returns>Arrays of int</returns>
      public Point[][] ToArrayOfArray()
      {
         int size = Size;
         Point[][] res = new Point[size][];
         for (int i = 0; i < size; i++)
         {
            using (VectorOfPoint v = this[i])
            {
               res[i] = v.ToArray();
            }
         }
         return res;
      }
#endif

      internal class DebuggerProxy
      {
         private VectorOfVectorOfPoint _v;

         public DebuggerProxy(VectorOfVectorOfPoint v)
         {
            _v = v;
         }

#if true
         public Point[][] Values
         {
            get { return _v.ToArrayOfArray(); }
         }
#else
		 public VectorOfPoint[] Values
         {
			get
			{
			   VectorOfPoint[] result = new VectorOfPoint[_v.Size];
			   for (int i = 0; i < result.Length; i++)
			   {
				  result[i] = _v[i];
			   }
			   return result;
			}
         }
#endif
      }


      [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
      internal static extern IntPtr VectorOfVectorOfPointCreate();

      [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
      internal static extern IntPtr VectorOfVectorOfPointCreateSize(int size);

      [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
      internal static extern void VectorOfVectorOfPointRelease(ref IntPtr v);

      [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
      internal static extern int VectorOfVectorOfPointGetSize(IntPtr v);

      [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
      internal static extern void VectorOfVectorOfPointPush(IntPtr v, IntPtr value);

      [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
      internal static extern void VectorOfVectorOfPointPushVector(IntPtr ptr, IntPtr otherPtr);
      
      [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
      internal static extern void VectorOfVectorOfPointClear(IntPtr v);

      [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
      internal static extern void VectorOfVectorOfPointGetItemPtr(IntPtr vec, int index, ref IntPtr element);

      [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
      internal static extern int VectorOfVectorOfPointSizeOfItemInBytes();

      [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
      internal static extern IntPtr cveInputArrayFromVectorOfVectorOfPoint(IntPtr vec);

      [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
      internal static extern IntPtr cveOutputArrayFromVectorOfVectorOfPoint(IntPtr vec);

      [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
      internal static extern IntPtr cveInputOutputArrayFromVectorOfVectorOfPoint(IntPtr vec);
   }
}


