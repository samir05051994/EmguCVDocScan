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
     internal static extern float cveRLOFOpticalFlowParameterGetNormSigma0(IntPtr obj);
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
     internal static extern void cveRLOFOpticalFlowParameterSetNormSigma0(
        IntPtr obj,  
        float val);
     
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)] 
     internal static extern float cveRLOFOpticalFlowParameterGetNormSigma1(IntPtr obj);
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
     internal static extern void cveRLOFOpticalFlowParameterSetNormSigma1(
        IntPtr obj,  
        float val);
     
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)] 
     internal static extern Emgu.CV.RLOFOpticalFlowParameter.SolverType cveRLOFOpticalFlowParameterGetSolver(IntPtr obj);
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
     internal static extern void cveRLOFOpticalFlowParameterSetSolver(
        IntPtr obj,  
        Emgu.CV.RLOFOpticalFlowParameter.SolverType val);
     
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)] 
     internal static extern Emgu.CV.RLOFOpticalFlowParameter.SupportRegionType cveRLOFOpticalFlowParameterGetSupportRegion(IntPtr obj);
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
     internal static extern void cveRLOFOpticalFlowParameterSetSupportRegion(
        IntPtr obj,  
        Emgu.CV.RLOFOpticalFlowParameter.SupportRegionType val);
     
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)] 
     internal static extern int cveRLOFOpticalFlowParameterGetSmallWinSize(IntPtr obj);
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
     internal static extern void cveRLOFOpticalFlowParameterSetSmallWinSize(
        IntPtr obj,  
        int val);
     
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)] 
     internal static extern int cveRLOFOpticalFlowParameterGetLargeWinSize(IntPtr obj);
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
     internal static extern void cveRLOFOpticalFlowParameterSetLargeWinSize(
        IntPtr obj,  
        int val);
     
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)] 
     internal static extern int cveRLOFOpticalFlowParameterGetCrossSegmentationThreshold(IntPtr obj);
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
     internal static extern void cveRLOFOpticalFlowParameterSetCrossSegmentationThreshold(
        IntPtr obj,  
        int val);
     
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)] 
     internal static extern int cveRLOFOpticalFlowParameterGetMaxLevel(IntPtr obj);
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
     internal static extern void cveRLOFOpticalFlowParameterSetMaxLevel(
        IntPtr obj,  
        int val);
     
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)] 
     [return: MarshalAs(CvInvoke.BoolMarshalType)]
     internal static extern bool cveRLOFOpticalFlowParameterGetUseInitialFlow(IntPtr obj);
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
     internal static extern void cveRLOFOpticalFlowParameterSetUseInitialFlow(
        IntPtr obj, 
        [MarshalAs(CvInvoke.BoolMarshalType)] 
        bool val);
     
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)] 
     [return: MarshalAs(CvInvoke.BoolMarshalType)]
     internal static extern bool cveRLOFOpticalFlowParameterGetUseIlluminationModel(IntPtr obj);
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
     internal static extern void cveRLOFOpticalFlowParameterSetUseIlluminationModel(
        IntPtr obj, 
        [MarshalAs(CvInvoke.BoolMarshalType)] 
        bool val);
     
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)] 
     [return: MarshalAs(CvInvoke.BoolMarshalType)]
     internal static extern bool cveRLOFOpticalFlowParameterGetUseGlobalMotionPrior(IntPtr obj);
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
     internal static extern void cveRLOFOpticalFlowParameterSetUseGlobalMotionPrior(
        IntPtr obj, 
        [MarshalAs(CvInvoke.BoolMarshalType)] 
        bool val);
     
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)] 
     internal static extern int cveRLOFOpticalFlowParameterGetMaxIteration(IntPtr obj);
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
     internal static extern void cveRLOFOpticalFlowParameterSetMaxIteration(
        IntPtr obj,  
        int val);
     
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)] 
     internal static extern float cveRLOFOpticalFlowParameterGetMinEigenValue(IntPtr obj);
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
     internal static extern void cveRLOFOpticalFlowParameterSetMinEigenValue(
        IntPtr obj,  
        float val);
     
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)] 
     internal static extern float cveRLOFOpticalFlowParameterGetGlobalMotionRansacThreshold(IntPtr obj);
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
     internal static extern void cveRLOFOpticalFlowParameterSetGlobalMotionRansacThreshold(
        IntPtr obj,  
        float val);
     
   }

   public partial class RLOFOpticalFlowParameter
   {

     /// <summary>
     /// parameter of the shrinked Hampel norm
     /// </summary>
     public float NormSigma0
     {
        get { return CvInvoke.cveRLOFOpticalFlowParameterGetNormSigma0(_ptr); } 
        set { CvInvoke.cveRLOFOpticalFlowParameterSetNormSigma0(_ptr, value); }
     }
     
     /// <summary>
     /// parameter of the shrinked Hampel norm
     /// </summary>
     public float NormSigma1
     {
        get { return CvInvoke.cveRLOFOpticalFlowParameterGetNormSigma1(_ptr); } 
        set { CvInvoke.cveRLOFOpticalFlowParameterSetNormSigma1(_ptr, value); }
     }
     
     /// <summary>
     /// Variable specifies the iterative refinement strategy
     /// </summary>
     public Emgu.CV.RLOFOpticalFlowParameter.SolverType Solver
     {
        get { return CvInvoke.cveRLOFOpticalFlowParameterGetSolver(_ptr); } 
        set { CvInvoke.cveRLOFOpticalFlowParameterSetSolver(_ptr, value); }
     }
     
     /// <summary>
     /// Variable specifies the support region shape extraction or shrinking strategy
     /// </summary>
     public Emgu.CV.RLOFOpticalFlowParameter.SupportRegionType SupportRegion
     {
        get { return CvInvoke.cveRLOFOpticalFlowParameterGetSupportRegion(_ptr); } 
        set { CvInvoke.cveRLOFOpticalFlowParameterSetSupportRegion(_ptr, value); }
     }
     
     /// <summary>
     /// Minimal window size of the support region. This parameter is only used if supportRegionType is Cross
     /// </summary>
     public int SmallWinSize
     {
        get { return CvInvoke.cveRLOFOpticalFlowParameterGetSmallWinSize(_ptr); } 
        set { CvInvoke.cveRLOFOpticalFlowParameterSetSmallWinSize(_ptr, value); }
     }
     
     /// <summary>
     /// Maximal window size of the support region. If supportRegionType is Fixed this gives the exact support region size. The speed of the RLOF is related to the applied win sizes. The smaller the window size the lower is the runtime, but the more sensitive to noise is the method.
     /// </summary>
     public int LargeWinSize
     {
        get { return CvInvoke.cveRLOFOpticalFlowParameterGetLargeWinSize(_ptr); } 
        set { CvInvoke.cveRLOFOpticalFlowParameterSetLargeWinSize(_ptr, value); }
     }
     
     /// <summary>
     /// Color similarity threshold used by cross-based segmentation. Only used  if supportRegionType is Cross. With the cross-bassed segmentation motion boundaries can be computed more accurately
     /// </summary>
     public int CrossSegmentationThreshold
     {
        get { return CvInvoke.cveRLOFOpticalFlowParameterGetCrossSegmentationThreshold(_ptr); } 
        set { CvInvoke.cveRLOFOpticalFlowParameterSetCrossSegmentationThreshold(_ptr, value); }
     }
     
     /// <summary>
     /// Maximal number of pyramid level used. The large this value is the more likely it is to obtain accurate solutions for long-range motions. The runtime is linear related to this parameter
     /// </summary>
     public int MaxLevel
     {
        get { return CvInvoke.cveRLOFOpticalFlowParameterGetMaxLevel(_ptr); } 
        set { CvInvoke.cveRLOFOpticalFlowParameterSetMaxLevel(_ptr, value); }
     }
     
     /// <summary>
     /// Use next point list as initial values. A good initialization can improve the algorithm accuracy and reduce the runtime by a faster convergence of the iteration refinement
     /// </summary>
     public bool UseInitialFlow
     {
        get { return CvInvoke.cveRLOFOpticalFlowParameterGetUseInitialFlow(_ptr); } 
        set { CvInvoke.cveRLOFOpticalFlowParameterSetUseInitialFlow(_ptr, value); }
     }
     
     /// <summary>
     /// Use the Gennert and Negahdaripour illumination model instead of the intensity brightness constraint.
     /// </summary>
     public bool UseIlluminationModel
     {
        get { return CvInvoke.cveRLOFOpticalFlowParameterGetUseIlluminationModel(_ptr); } 
        set { CvInvoke.cveRLOFOpticalFlowParameterSetUseIlluminationModel(_ptr, value); }
     }
     
     /// <summary>
     /// Use global motion prior initialisation. It allows to be more accurate for long-range motion. The computational complexity is slightly increased by enabling the global motion prior initialisation.
     /// </summary>
     public bool UseGlobalMotionPrior
     {
        get { return CvInvoke.cveRLOFOpticalFlowParameterGetUseGlobalMotionPrior(_ptr); } 
        set { CvInvoke.cveRLOFOpticalFlowParameterSetUseGlobalMotionPrior(_ptr, value); }
     }
     
     /// <summary>
     /// Number of maximal iterations used for the iterative refinement. Lower values can reduce the runtime but also the accuracy.
     /// </summary>
     public int MaxIteration
     {
        get { return CvInvoke.cveRLOFOpticalFlowParameterGetMaxIteration(_ptr); } 
        set { CvInvoke.cveRLOFOpticalFlowParameterSetMaxIteration(_ptr, value); }
     }
     
     /// <summary>
     /// Threshold for the minimal eigenvalue of the gradient matrix defines when to abort the iterative refinement.
     /// </summary>
     public float MinEigenValue
     {
        get { return CvInvoke.cveRLOFOpticalFlowParameterGetMinEigenValue(_ptr); } 
        set { CvInvoke.cveRLOFOpticalFlowParameterSetMinEigenValue(_ptr, value); }
     }
     
     /// <summary>
     /// To apply the global motion prior motion vectors will be computed on a regularly sampled which are the basis for Homography estimation using RANSAC. The reprojection threshold is based on n-th percentil (given by this value [0 ... 100]) of the motion vectors magnitude.
     /// </summary>
     public float GlobalMotionRansacThreshold
     {
        get { return CvInvoke.cveRLOFOpticalFlowParameterGetGlobalMotionRansacThreshold(_ptr); } 
        set { CvInvoke.cveRLOFOpticalFlowParameterSetGlobalMotionRansacThreshold(_ptr, value); }
     }
     
   }
}
