//----------------------------------------------------------------------------
//  This file is automatically generated, do not modify.      
//----------------------------------------------------------------------------



using System;
using System.Runtime.InteropServices;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.Util;

namespace Emgu.CV.Cuda
{
   public static partial class CudaInvoke
   {

     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)] 
     internal static extern float cveCudaHoughLinesDetectorGetRho(IntPtr obj);
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
     internal static extern void cveCudaHoughLinesDetectorSetRho(
        IntPtr obj,  
        float val);
     
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)] 
     internal static extern float cveCudaHoughLinesDetectorGetTheta(IntPtr obj);
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
     internal static extern void cveCudaHoughLinesDetectorSetTheta(
        IntPtr obj,  
        float val);
     
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)] 
     internal static extern int cveCudaHoughLinesDetectorGetThreshold(IntPtr obj);
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
     internal static extern void cveCudaHoughLinesDetectorSetThreshold(
        IntPtr obj,  
        int val);
     
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)] 
     [return: MarshalAs(CvInvoke.BoolMarshalType)]
     internal static extern bool cveCudaHoughLinesDetectorGetDoSort(IntPtr obj);
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
     internal static extern void cveCudaHoughLinesDetectorSetDoSort(
        IntPtr obj, 
        [MarshalAs(CvInvoke.BoolMarshalType)] 
        bool val);
     
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)] 
     internal static extern int cveCudaHoughLinesDetectorGetMaxLines(IntPtr obj);
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
     internal static extern void cveCudaHoughLinesDetectorSetMaxLines(
        IntPtr obj,  
        int val);
     
   }

   public partial class CudaHoughLinesDetector
   {

     /// <summary>
     /// Distance resolution of the accumulator in pixels
     /// </summary>
     public float Rho
     {
        get { return CudaInvoke.cveCudaHoughLinesDetectorGetRho(_ptr); } 
        set { CudaInvoke.cveCudaHoughLinesDetectorSetRho(_ptr, value); }
     }
     
     /// <summary>
     /// Angle resolution of the accumulator in radians
     /// </summary>
     public float Theta
     {
        get { return CudaInvoke.cveCudaHoughLinesDetectorGetTheta(_ptr); } 
        set { CudaInvoke.cveCudaHoughLinesDetectorSetTheta(_ptr, value); }
     }
     
     /// <summary>
     /// Accumulator threshold parameter. Only those lines are returned that get enough
     /// </summary>
     public int Threshold
     {
        get { return CudaInvoke.cveCudaHoughLinesDetectorGetThreshold(_ptr); } 
        set { CudaInvoke.cveCudaHoughLinesDetectorSetThreshold(_ptr, value); }
     }
     
     /// <summary>
     /// Performs lines sort by votes
     /// </summary>
     public bool DoSort
     {
        get { return CudaInvoke.cveCudaHoughLinesDetectorGetDoSort(_ptr); } 
        set { CudaInvoke.cveCudaHoughLinesDetectorSetDoSort(_ptr, value); }
     }
     
     /// <summary>
     /// Maximum number of output lines
     /// </summary>
     public int MaxLines
     {
        get { return CudaInvoke.cveCudaHoughLinesDetectorGetMaxLines(_ptr); } 
        set { CudaInvoke.cveCudaHoughLinesDetectorSetMaxLines(_ptr, value); }
     }
     
   }
}
