//----------------------------------------------------------------------------
//  This file is automatically generated, do not modify.      
//----------------------------------------------------------------------------



using System;
using System.Runtime.InteropServices;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.Util;

namespace Emgu.CV
{
   public static partial class CvInvoke
   {

     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)] 
     internal static extern IntPtr cveKalmanFilterGetStatePre(IntPtr obj);
     
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)] 
     internal static extern IntPtr cveKalmanFilterGetStatePost(IntPtr obj);
     
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)] 
     internal static extern IntPtr cveKalmanFilterGetTransitionMatrix(IntPtr obj);
     
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)] 
     internal static extern IntPtr cveKalmanFilterGetControlMatrix(IntPtr obj);
     
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)] 
     internal static extern IntPtr cveKalmanFilterGetMeasurementMatrix(IntPtr obj);
     
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)] 
     internal static extern IntPtr cveKalmanFilterGetProcessNoiseCov(IntPtr obj);
     
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)] 
     internal static extern IntPtr cveKalmanFilterGetMeasurementNoiseCov(IntPtr obj);
     
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)] 
     internal static extern IntPtr cveKalmanFilterGetErrorCovPre(IntPtr obj);
     
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)] 
     internal static extern IntPtr cveKalmanFilterGetGain(IntPtr obj);
     
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)] 
     internal static extern IntPtr cveKalmanFilterGetErrorCovPost(IntPtr obj);
     
   }

   public partial class KalmanFilter
   {

     /// <summary>
     /// Predicted state (x'(k)): x(k)=A*x(k-1)+B*u(k)
     /// </summary>
	 /// <returns>The result</returns>
     public Mat StatePre
     {
        get { return new Mat( CvInvoke.cveKalmanFilterGetStatePre(_ptr), false); } 
     }
     
     /// <summary>
     /// Corrected state (x(k)): x(k)=x'(k)+K(k)*(z(k)-H*x'(k))
     /// </summary>
	 /// <returns>The result</returns>
     public Mat StatePost
     {
        get { return new Mat( CvInvoke.cveKalmanFilterGetStatePost(_ptr), false); } 
     }
     
     /// <summary>
     /// State transition matrix (A)
     /// </summary>
	 /// <returns>The result</returns>
     public Mat TransitionMatrix
     {
        get { return new Mat( CvInvoke.cveKalmanFilterGetTransitionMatrix(_ptr), false); } 
     }
     
     /// <summary>
     /// Control matrix (B) (not used if there is no control)
     /// </summary>
	 /// <returns>The result</returns>
     public Mat ControlMatrix
     {
        get { return new Mat( CvInvoke.cveKalmanFilterGetControlMatrix(_ptr), false); } 
     }
     
     /// <summary>
     /// Measurement matrix (H)
     /// </summary>
	 /// <returns>The result</returns>
     public Mat MeasurementMatrix
     {
        get { return new Mat( CvInvoke.cveKalmanFilterGetMeasurementMatrix(_ptr), false); } 
     }
     
     /// <summary>
     /// Process noise covariance matrix (Q)
     /// </summary>
	 /// <returns>The result</returns>
     public Mat ProcessNoiseCov
     {
        get { return new Mat( CvInvoke.cveKalmanFilterGetProcessNoiseCov(_ptr), false); } 
     }
     
     /// <summary>
     /// Measurement noise covariance matrix (R)
     /// </summary>
	 /// <returns>The result</returns>
     public Mat MeasurementNoiseCov
     {
        get { return new Mat( CvInvoke.cveKalmanFilterGetMeasurementNoiseCov(_ptr), false); } 
     }
     
     /// <summary>
     /// priori error estimate covariance matrix (P'(k)): P'(k)=A*P(k-1)*At + Q)
     /// </summary>
	 /// <returns>The result</returns>
     public Mat ErrorCovPre
     {
        get { return new Mat( CvInvoke.cveKalmanFilterGetErrorCovPre(_ptr), false); } 
     }
     
     /// <summary>
     /// Kalman gain matrix (K(k)): K(k)=P'(k)*Ht*inv(H*P'(k)*Ht+R)
     /// </summary>
	 /// <returns>The result</returns>
     public Mat Gain
     {
        get { return new Mat( CvInvoke.cveKalmanFilterGetGain(_ptr), false); } 
     }
     
     /// <summary>
     /// posteriori error estimate covariance matrix (P(k)): P(k)=(I-K(k)*H)*P'(k)
     /// </summary>
	 /// <returns>The result</returns>
     public Mat ErrorCovPost
     {
        get { return new Mat( CvInvoke.cveKalmanFilterGetErrorCovPost(_ptr), false); } 
     }
     
   }
}
