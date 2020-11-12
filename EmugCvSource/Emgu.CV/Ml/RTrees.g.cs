//----------------------------------------------------------------------------
//  This file is automatically generated, do not modify.      
//----------------------------------------------------------------------------



using System;
using System.Runtime.InteropServices;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.Util;

namespace Emgu.CV.ML
{
   public static partial class MlInvoke
   {

     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)] 
     internal static extern int cveRTreesGetMaxCategories(IntPtr obj);
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
     internal static extern void cveRTreesSetMaxCategories(
        IntPtr obj,  
        int val);
     
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)] 
     internal static extern int cveRTreesGetMaxDepth(IntPtr obj);
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
     internal static extern void cveRTreesSetMaxDepth(
        IntPtr obj,  
        int val);
     
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)] 
     internal static extern int cveRTreesGetMinSampleCount(IntPtr obj);
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
     internal static extern void cveRTreesSetMinSampleCount(
        IntPtr obj,  
        int val);
     
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)] 
     internal static extern int cveRTreesGetCVFolds(IntPtr obj);
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
     internal static extern void cveRTreesSetCVFolds(
        IntPtr obj,  
        int val);
     
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)] 
     [return: MarshalAs(CvInvoke.BoolMarshalType)]
     internal static extern bool cveRTreesGetUseSurrogates(IntPtr obj);
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
     internal static extern void cveRTreesSetUseSurrogates(
        IntPtr obj, 
        [MarshalAs(CvInvoke.BoolMarshalType)] 
        bool val);
     
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)] 
     [return: MarshalAs(CvInvoke.BoolMarshalType)]
     internal static extern bool cveRTreesGetUse1SERule(IntPtr obj);
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
     internal static extern void cveRTreesSetUse1SERule(
        IntPtr obj, 
        [MarshalAs(CvInvoke.BoolMarshalType)] 
        bool val);
     
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)] 
     [return: MarshalAs(CvInvoke.BoolMarshalType)]
     internal static extern bool cveRTreesGetTruncatePrunedTree(IntPtr obj);
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
     internal static extern void cveRTreesSetTruncatePrunedTree(
        IntPtr obj, 
        [MarshalAs(CvInvoke.BoolMarshalType)] 
        bool val);
     
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)] 
     internal static extern float cveRTreesGetRegressionAccuracy(IntPtr obj);
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
     internal static extern void cveRTreesSetRegressionAccuracy(
        IntPtr obj,  
        float val);
     
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)] 
     [return: MarshalAs(CvInvoke.BoolMarshalType)]
     internal static extern bool cveRTreesGetCalculateVarImportance(IntPtr obj);
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
     internal static extern void cveRTreesSetCalculateVarImportance(
        IntPtr obj, 
        [MarshalAs(CvInvoke.BoolMarshalType)] 
        bool val);
     
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)] 
     internal static extern int cveRTreesGetActiveVarCount(IntPtr obj);
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
     internal static extern void cveRTreesSetActiveVarCount(
        IntPtr obj,  
        int val);
     
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
     internal static extern void cveRTreesGetTermCriteria(IntPtr obj, ref MCvTermCriteria val);
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
     internal static extern void cveRTreesSetTermCriteria(IntPtr obj, ref MCvTermCriteria val);
     
   }

   public partial class RTrees
   {

     /// <summary>
     /// Cluster possible values of a categorical variable into K less than or equals maxCategories clusters to find a suboptimal split
     /// </summary>
     public int MaxCategories
     {
        get { return MlInvoke.cveRTreesGetMaxCategories(_ptr); } 
        set { MlInvoke.cveRTreesSetMaxCategories(_ptr, value); }
     }
     
     /// <summary>
     /// The maximum possible depth of the tree
     /// </summary>
     public int MaxDepth
     {
        get { return MlInvoke.cveRTreesGetMaxDepth(_ptr); } 
        set { MlInvoke.cveRTreesSetMaxDepth(_ptr, value); }
     }
     
     /// <summary>
     /// If the number of samples in a node is less than this parameter then the node will not be split
     /// </summary>
     public int MinSampleCount
     {
        get { return MlInvoke.cveRTreesGetMinSampleCount(_ptr); } 
        set { MlInvoke.cveRTreesSetMinSampleCount(_ptr, value); }
     }
     
     /// <summary>
     /// If CVFolds greater than 1 then algorithms prunes the built decision tree using K-fold
     /// </summary>
     public int CVFolds
     {
        get { return MlInvoke.cveRTreesGetCVFolds(_ptr); } 
        set { MlInvoke.cveRTreesSetCVFolds(_ptr, value); }
     }
     
     /// <summary>
     /// If true then surrogate splits will be built
     /// </summary>
     public bool UseSurrogates
     {
        get { return MlInvoke.cveRTreesGetUseSurrogates(_ptr); } 
        set { MlInvoke.cveRTreesSetUseSurrogates(_ptr, value); }
     }
     
     /// <summary>
     /// If true then a pruning will be harsher
     /// </summary>
     public bool Use1SERule
     {
        get { return MlInvoke.cveRTreesGetUse1SERule(_ptr); } 
        set { MlInvoke.cveRTreesSetUse1SERule(_ptr, value); }
     }
     
     /// <summary>
     /// If true then pruned branches are physically removed from the tree
     /// </summary>
     public bool TruncatePrunedTree
     {
        get { return MlInvoke.cveRTreesGetTruncatePrunedTree(_ptr); } 
        set { MlInvoke.cveRTreesSetTruncatePrunedTree(_ptr, value); }
     }
     
     /// <summary>
     /// Termination criteria for regression trees
     /// </summary>
     public float RegressionAccuracy
     {
        get { return MlInvoke.cveRTreesGetRegressionAccuracy(_ptr); } 
        set { MlInvoke.cveRTreesSetRegressionAccuracy(_ptr, value); }
     }
     
     /// <summary>
     /// If true then variable importance will be calculated
     /// </summary>
     public bool CalculateVarImportance
     {
        get { return MlInvoke.cveRTreesGetCalculateVarImportance(_ptr); } 
        set { MlInvoke.cveRTreesSetCalculateVarImportance(_ptr, value); }
     }
     
     /// <summary>
     /// The size of the randomly selected subset of features at each tree node and that are used to find the best split(s)
     /// </summary>
     public int ActiveVarCount
     {
        get { return MlInvoke.cveRTreesGetActiveVarCount(_ptr); } 
        set { MlInvoke.cveRTreesSetActiveVarCount(_ptr, value); }
     }
     
     /// <summary>
     /// The termination criteria that specifies when the training algorithm stops
     /// </summary>
     public MCvTermCriteria TermCriteria
     {
        get { MCvTermCriteria v = new MCvTermCriteria(); MlInvoke.cveRTreesGetTermCriteria(_ptr, ref v); return v; } 
        set { MlInvoke.cveRTreesSetTermCriteria(_ptr, ref value); }
     }
     
   }
}