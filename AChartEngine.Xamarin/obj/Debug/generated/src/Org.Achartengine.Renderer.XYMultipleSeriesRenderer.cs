using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Achartengine.Renderer {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYMultipleSeriesRenderer']"
	[global::Android.Runtime.Register ("org/achartengine/renderer/XYMultipleSeriesRenderer", DoNotGenerateAcw=true)]
	public partial class XYMultipleSeriesRenderer : global::Org.Achartengine.Renderer.DefaultRenderer {

		// Metadata.xml XPath class reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYMultipleSeriesRenderer.Orientation']"
		[global::Android.Runtime.Register ("org/achartengine/renderer/XYMultipleSeriesRenderer$Orientation", DoNotGenerateAcw=true)]
		public sealed partial class Orientation : global::Java.Lang.Enum {


			static IntPtr HORIZONTAL_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYMultipleSeriesRenderer.Orientation']/field[@name='HORIZONTAL']"
			[Register ("HORIZONTAL")]
			public static global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer.Orientation Horizontal {
				get {
					if (HORIZONTAL_jfieldId == IntPtr.Zero)
						HORIZONTAL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "HORIZONTAL", "Lorg/achartengine/renderer/XYMultipleSeriesRenderer$Orientation;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, HORIZONTAL_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer.Orientation> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (HORIZONTAL_jfieldId == IntPtr.Zero)
						HORIZONTAL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "HORIZONTAL", "Lorg/achartengine/renderer/XYMultipleSeriesRenderer$Orientation;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, HORIZONTAL_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr VERTICAL_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYMultipleSeriesRenderer.Orientation']/field[@name='VERTICAL']"
			[Register ("VERTICAL")]
			public static global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer.Orientation Vertical {
				get {
					if (VERTICAL_jfieldId == IntPtr.Zero)
						VERTICAL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VERTICAL", "Lorg/achartengine/renderer/XYMultipleSeriesRenderer$Orientation;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VERTICAL_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer.Orientation> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (VERTICAL_jfieldId == IntPtr.Zero)
						VERTICAL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VERTICAL", "Lorg/achartengine/renderer/XYMultipleSeriesRenderer$Orientation;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, VERTICAL_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/achartengine/renderer/XYMultipleSeriesRenderer$Orientation", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Orientation); }
			}

			internal Orientation (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_getAngle;
			public int Angle {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYMultipleSeriesRenderer.Orientation']/method[@name='getAngle' and count(parameter)=0]"
				[Register ("getAngle", "()I", "GetGetAngleHandler")]
				get {
					if (id_getAngle == IntPtr.Zero)
						id_getAngle = JNIEnv.GetMethodID (class_ref, "getAngle", "()I");
					return JNIEnv.CallIntMethod  (Handle, id_getAngle);
				}
			}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYMultipleSeriesRenderer.Orientation']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lorg/achartengine/renderer/XYMultipleSeriesRenderer$Orientation;", "")]
			public static global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer.Orientation ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lorg/achartengine/renderer/XYMultipleSeriesRenderer$Orientation;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer.Orientation __ret = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer.Orientation> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYMultipleSeriesRenderer.Orientation']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lorg/achartengine/renderer/XYMultipleSeriesRenderer$Orientation;", "")]
			public static global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer.Orientation[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lorg/achartengine/renderer/XYMultipleSeriesRenderer$Orientation;");
				return (global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer.Orientation[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer.Orientation));
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/achartengine/renderer/XYMultipleSeriesRenderer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (XYMultipleSeriesRenderer); }
		}

		protected XYMultipleSeriesRenderer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYMultipleSeriesRenderer']/constructor[@name='XYMultipleSeriesRenderer' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public XYMultipleSeriesRenderer (int p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (XYMultipleSeriesRenderer)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(I)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(I)V", new JValue (p0));
				return;
			}

			if (id_ctor_I == IntPtr.Zero)
				id_ctor_I = JNIEnv.GetMethodID (class_ref, "<init>", "(I)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_I, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_I, new JValue (p0));
		}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYMultipleSeriesRenderer']/constructor[@name='XYMultipleSeriesRenderer' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public XYMultipleSeriesRenderer () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (XYMultipleSeriesRenderer)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
		}

		static Delegate cb_getAxisTitleTextSize;
#pragma warning disable 0169
		static Delegate GetGetAxisTitleTextSizeHandler ()
		{
			if (cb_getAxisTitleTextSize == null)
				cb_getAxisTitleTextSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetAxisTitleTextSize);
			return cb_getAxisTitleTextSize;
		}

		static float n_GetAxisTitleTextSize (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AxisTitleTextSize;
		}
#pragma warning restore 0169

		static Delegate cb_setAxisTitleTextSize_F;
#pragma warning disable 0169
		static Delegate GetSetAxisTitleTextSize_FHandler ()
		{
			if (cb_setAxisTitleTextSize_F == null)
				cb_setAxisTitleTextSize_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetAxisTitleTextSize_F);
			return cb_setAxisTitleTextSize_F;
		}

		static void n_SetAxisTitleTextSize_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AxisTitleTextSize = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getAxisTitleTextSize;
		static IntPtr id_setAxisTitleTextSize_F;
		public virtual float AxisTitleTextSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYMultipleSeriesRenderer']/method[@name='getAxisTitleTextSize' and count(parameter)=0]"
			[Register ("getAxisTitleTextSize", "()F", "GetGetAxisTitleTextSizeHandler")]
			get {
				if (id_getAxisTitleTextSize == IntPtr.Zero)
					id_getAxisTitleTextSize = JNIEnv.GetMethodID (class_ref, "getAxisTitleTextSize", "()F");

				if (GetType () == ThresholdType)
					return JNIEnv.CallFloatMethod  (Handle, id_getAxisTitleTextSize);
				else
					return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, id_getAxisTitleTextSize);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYMultipleSeriesRenderer']/method[@name='setAxisTitleTextSize' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setAxisTitleTextSize", "(F)V", "GetSetAxisTitleTextSize_FHandler")]
			set {
				if (id_setAxisTitleTextSize_F == IntPtr.Zero)
					id_setAxisTitleTextSize_F = JNIEnv.GetMethodID (class_ref, "setAxisTitleTextSize", "(F)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setAxisTitleTextSize_F, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setAxisTitleTextSize_F, new JValue (value));
			}
		}

		static Delegate cb_getBarSpacing;
#pragma warning disable 0169
		static Delegate GetGetBarSpacingHandler ()
		{
			if (cb_getBarSpacing == null)
				cb_getBarSpacing = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetBarSpacing);
			return cb_getBarSpacing;
		}

		static double n_GetBarSpacing (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BarSpacing;
		}
#pragma warning restore 0169

		static Delegate cb_setBarSpacing_D;
#pragma warning disable 0169
		static Delegate GetSetBarSpacing_DHandler ()
		{
			if (cb_setBarSpacing_D == null)
				cb_setBarSpacing_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_SetBarSpacing_D);
			return cb_setBarSpacing_D;
		}

		static void n_SetBarSpacing_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.BarSpacing = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getBarSpacing;
		static IntPtr id_setBarSpacing_D;
		public virtual double BarSpacing {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYMultipleSeriesRenderer']/method[@name='getBarSpacing' and count(parameter)=0]"
			[Register ("getBarSpacing", "()D", "GetGetBarSpacingHandler")]
			get {
				if (id_getBarSpacing == IntPtr.Zero)
					id_getBarSpacing = JNIEnv.GetMethodID (class_ref, "getBarSpacing", "()D");

				if (GetType () == ThresholdType)
					return JNIEnv.CallDoubleMethod  (Handle, id_getBarSpacing);
				else
					return JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, id_getBarSpacing);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYMultipleSeriesRenderer']/method[@name='setBarSpacing' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setBarSpacing", "(D)V", "GetSetBarSpacing_DHandler")]
			set {
				if (id_setBarSpacing_D == IntPtr.Zero)
					id_setBarSpacing_D = JNIEnv.GetMethodID (class_ref, "setBarSpacing", "(D)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setBarSpacing_D, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setBarSpacing_D, new JValue (value));
			}
		}

		static Delegate cb_getBarWidth;
#pragma warning disable 0169
		static Delegate GetGetBarWidthHandler ()
		{
			if (cb_getBarWidth == null)
				cb_getBarWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetBarWidth);
			return cb_getBarWidth;
		}

		static float n_GetBarWidth (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BarWidth;
		}
#pragma warning restore 0169

		static Delegate cb_setBarWidth_F;
#pragma warning disable 0169
		static Delegate GetSetBarWidth_FHandler ()
		{
			if (cb_setBarWidth_F == null)
				cb_setBarWidth_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetBarWidth_F);
			return cb_setBarWidth_F;
		}

		static void n_SetBarWidth_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.BarWidth = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getBarWidth;
		static IntPtr id_setBarWidth_F;
		public virtual float BarWidth {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYMultipleSeriesRenderer']/method[@name='getBarWidth' and count(parameter)=0]"
			[Register ("getBarWidth", "()F", "GetGetBarWidthHandler")]
			get {
				if (id_getBarWidth == IntPtr.Zero)
					id_getBarWidth = JNIEnv.GetMethodID (class_ref, "getBarWidth", "()F");

				if (GetType () == ThresholdType)
					return JNIEnv.CallFloatMethod  (Handle, id_getBarWidth);
				else
					return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, id_getBarWidth);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYMultipleSeriesRenderer']/method[@name='setBarWidth' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setBarWidth", "(F)V", "GetSetBarWidth_FHandler")]
			set {
				if (id_setBarWidth_F == IntPtr.Zero)
					id_setBarWidth_F = JNIEnv.GetMethodID (class_ref, "setBarWidth", "(F)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setBarWidth_F, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setBarWidth_F, new JValue (value));
			}
		}

		static Delegate cb_getBarsSpacing;
#pragma warning disable 0169
		static Delegate GetGetBarsSpacingHandler ()
		{
			if (cb_getBarsSpacing == null)
				cb_getBarsSpacing = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetBarsSpacing);
			return cb_getBarsSpacing;
		}

		static double n_GetBarsSpacing (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BarsSpacing;
		}
#pragma warning restore 0169

		static IntPtr id_getBarsSpacing;
		public virtual double BarsSpacing {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYMultipleSeriesRenderer']/method[@name='getBarsSpacing' and count(parameter)=0]"
			[Register ("getBarsSpacing", "()D", "GetGetBarsSpacingHandler")]
			get {
				if (id_getBarsSpacing == IntPtr.Zero)
					id_getBarsSpacing = JNIEnv.GetMethodID (class_ref, "getBarsSpacing", "()D");

				if (GetType () == ThresholdType)
					return JNIEnv.CallDoubleMethod  (Handle, id_getBarsSpacing);
				else
					return JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, id_getBarsSpacing);
			}
		}

		static Delegate cb_getGridColor;
#pragma warning disable 0169
		static Delegate GetGetGridColorHandler ()
		{
			if (cb_getGridColor == null)
				cb_getGridColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetGridColor);
			return cb_getGridColor;
		}

		static int n_GetGridColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GridColor;
		}
#pragma warning restore 0169

		static Delegate cb_setGridColor_I;
#pragma warning disable 0169
		static Delegate GetSetGridColor_IHandler ()
		{
			if (cb_setGridColor_I == null)
				cb_setGridColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetGridColor_I);
			return cb_setGridColor_I;
		}

		static void n_SetGridColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.GridColor = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getGridColor;
		static IntPtr id_setGridColor_I;
		public virtual int GridColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYMultipleSeriesRenderer']/method[@name='getGridColor' and count(parameter)=0]"
			[Register ("getGridColor", "()I", "GetGetGridColorHandler")]
			get {
				if (id_getGridColor == IntPtr.Zero)
					id_getGridColor = JNIEnv.GetMethodID (class_ref, "getGridColor", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getGridColor);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, id_getGridColor);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYMultipleSeriesRenderer']/method[@name='setGridColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setGridColor", "(I)V", "GetSetGridColor_IHandler")]
			set {
				if (id_setGridColor_I == IntPtr.Zero)
					id_setGridColor_I = JNIEnv.GetMethodID (class_ref, "setGridColor", "(I)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setGridColor_I, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setGridColor_I, new JValue (value));
			}
		}

		static Delegate cb_isInitialRangeSet;
#pragma warning disable 0169
		static Delegate GetIsInitialRangeSetHandler ()
		{
			if (cb_isInitialRangeSet == null)
				cb_isInitialRangeSet = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsInitialRangeSet);
			return cb_isInitialRangeSet;
		}

		static bool n_IsInitialRangeSet (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsInitialRangeSet;
		}
#pragma warning restore 0169

		static IntPtr id_isInitialRangeSet;
		public virtual bool IsInitialRangeSet {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYMultipleSeriesRenderer']/method[@name='isInitialRangeSet' and count(parameter)=0]"
			[Register ("isInitialRangeSet", "()Z", "GetIsInitialRangeSetHandler")]
			get {
				if (id_isInitialRangeSet == IntPtr.Zero)
					id_isInitialRangeSet = JNIEnv.GetMethodID (class_ref, "isInitialRangeSet", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isInitialRangeSet);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_isInitialRangeSet);
			}
		}

		static Delegate cb_isMaxXSet;
#pragma warning disable 0169
		static Delegate GetIsMaxXSetHandler ()
		{
			if (cb_isMaxXSet == null)
				cb_isMaxXSet = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsMaxXSet);
			return cb_isMaxXSet;
		}

		static bool n_IsMaxXSet (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsMaxXSet;
		}
#pragma warning restore 0169

		static IntPtr id_isMaxXSet;
		public virtual bool IsMaxXSet {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYMultipleSeriesRenderer']/method[@name='isMaxXSet' and count(parameter)=0]"
			[Register ("isMaxXSet", "()Z", "GetIsMaxXSetHandler")]
			get {
				if (id_isMaxXSet == IntPtr.Zero)
					id_isMaxXSet = JNIEnv.GetMethodID (class_ref, "isMaxXSet", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isMaxXSet);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_isMaxXSet);
			}
		}

		static Delegate cb_isMaxYSet;
#pragma warning disable 0169
		static Delegate GetIsMaxYSetHandler ()
		{
			if (cb_isMaxYSet == null)
				cb_isMaxYSet = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsMaxYSet);
			return cb_isMaxYSet;
		}

		static bool n_IsMaxYSet (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsMaxYSet;
		}
#pragma warning restore 0169

		static IntPtr id_isMaxYSet;
		public virtual bool IsMaxYSet {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYMultipleSeriesRenderer']/method[@name='isMaxYSet' and count(parameter)=0]"
			[Register ("isMaxYSet", "()Z", "GetIsMaxYSetHandler")]
			get {
				if (id_isMaxYSet == IntPtr.Zero)
					id_isMaxYSet = JNIEnv.GetMethodID (class_ref, "isMaxYSet", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isMaxYSet);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_isMaxYSet);
			}
		}

		static Delegate cb_isMinXSet;
#pragma warning disable 0169
		static Delegate GetIsMinXSetHandler ()
		{
			if (cb_isMinXSet == null)
				cb_isMinXSet = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsMinXSet);
			return cb_isMinXSet;
		}

		static bool n_IsMinXSet (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsMinXSet;
		}
#pragma warning restore 0169

		static IntPtr id_isMinXSet;
		public virtual bool IsMinXSet {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYMultipleSeriesRenderer']/method[@name='isMinXSet' and count(parameter)=0]"
			[Register ("isMinXSet", "()Z", "GetIsMinXSetHandler")]
			get {
				if (id_isMinXSet == IntPtr.Zero)
					id_isMinXSet = JNIEnv.GetMethodID (class_ref, "isMinXSet", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isMinXSet);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_isMinXSet);
			}
		}

		static Delegate cb_isMinYSet;
#pragma warning disable 0169
		static Delegate GetIsMinYSetHandler ()
		{
			if (cb_isMinYSet == null)
				cb_isMinYSet = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsMinYSet);
			return cb_isMinYSet;
		}

		static bool n_IsMinYSet (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsMinYSet;
		}
#pragma warning restore 0169

		static IntPtr id_isMinYSet;
		public virtual bool IsMinYSet {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYMultipleSeriesRenderer']/method[@name='isMinYSet' and count(parameter)=0]"
			[Register ("isMinYSet", "()Z", "GetIsMinYSetHandler")]
			get {
				if (id_isMinYSet == IntPtr.Zero)
					id_isMinYSet = JNIEnv.GetMethodID (class_ref, "isMinYSet", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isMinYSet);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_isMinYSet);
			}
		}

		static Delegate cb_isPanXEnabled;
#pragma warning disable 0169
		static Delegate GetIsPanXEnabledHandler ()
		{
			if (cb_isPanXEnabled == null)
				cb_isPanXEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsPanXEnabled);
			return cb_isPanXEnabled;
		}

		static bool n_IsPanXEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsPanXEnabled;
		}
#pragma warning restore 0169

		static IntPtr id_isPanXEnabled;
		public virtual bool IsPanXEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYMultipleSeriesRenderer']/method[@name='isPanXEnabled' and count(parameter)=0]"
			[Register ("isPanXEnabled", "()Z", "GetIsPanXEnabledHandler")]
			get {
				if (id_isPanXEnabled == IntPtr.Zero)
					id_isPanXEnabled = JNIEnv.GetMethodID (class_ref, "isPanXEnabled", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isPanXEnabled);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_isPanXEnabled);
			}
		}

		static Delegate cb_isPanYEnabled;
#pragma warning disable 0169
		static Delegate GetIsPanYEnabledHandler ()
		{
			if (cb_isPanYEnabled == null)
				cb_isPanYEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsPanYEnabled);
			return cb_isPanYEnabled;
		}

		static bool n_IsPanYEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsPanYEnabled;
		}
#pragma warning restore 0169

		static IntPtr id_isPanYEnabled;
		public virtual bool IsPanYEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYMultipleSeriesRenderer']/method[@name='isPanYEnabled' and count(parameter)=0]"
			[Register ("isPanYEnabled", "()Z", "GetIsPanYEnabledHandler")]
			get {
				if (id_isPanYEnabled == IntPtr.Zero)
					id_isPanYEnabled = JNIEnv.GetMethodID (class_ref, "isPanYEnabled", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isPanYEnabled);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_isPanYEnabled);
			}
		}

		static Delegate cb_isZoomXEnabled;
#pragma warning disable 0169
		static Delegate GetIsZoomXEnabledHandler ()
		{
			if (cb_isZoomXEnabled == null)
				cb_isZoomXEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsZoomXEnabled);
			return cb_isZoomXEnabled;
		}

		static bool n_IsZoomXEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsZoomXEnabled;
		}
#pragma warning restore 0169

		static IntPtr id_isZoomXEnabled;
		public virtual bool IsZoomXEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYMultipleSeriesRenderer']/method[@name='isZoomXEnabled' and count(parameter)=0]"
			[Register ("isZoomXEnabled", "()Z", "GetIsZoomXEnabledHandler")]
			get {
				if (id_isZoomXEnabled == IntPtr.Zero)
					id_isZoomXEnabled = JNIEnv.GetMethodID (class_ref, "isZoomXEnabled", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isZoomXEnabled);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_isZoomXEnabled);
			}
		}

		static Delegate cb_isZoomYEnabled;
#pragma warning disable 0169
		static Delegate GetIsZoomYEnabledHandler ()
		{
			if (cb_isZoomYEnabled == null)
				cb_isZoomYEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsZoomYEnabled);
			return cb_isZoomYEnabled;
		}

		static bool n_IsZoomYEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsZoomYEnabled;
		}
#pragma warning restore 0169

		static IntPtr id_isZoomYEnabled;
		public virtual bool IsZoomYEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYMultipleSeriesRenderer']/method[@name='isZoomYEnabled' and count(parameter)=0]"
			[Register ("isZoomYEnabled", "()Z", "GetIsZoomYEnabledHandler")]
			get {
				if (id_isZoomYEnabled == IntPtr.Zero)
					id_isZoomYEnabled = JNIEnv.GetMethodID (class_ref, "isZoomYEnabled", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isZoomYEnabled);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_isZoomYEnabled);
			}
		}

		static Delegate cb_getLabelFormat;
#pragma warning disable 0169
		static Delegate GetGetLabelFormatHandler ()
		{
			if (cb_getLabelFormat == null)
				cb_getLabelFormat = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLabelFormat);
			return cb_getLabelFormat;
		}

		static IntPtr n_GetLabelFormat (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.LabelFormat);
		}
#pragma warning restore 0169

		static Delegate cb_setLabelFormat_Ljava_text_NumberFormat_;
#pragma warning disable 0169
		static Delegate GetSetLabelFormat_Ljava_text_NumberFormat_Handler ()
		{
			if (cb_setLabelFormat_Ljava_text_NumberFormat_ == null)
				cb_setLabelFormat_Ljava_text_NumberFormat_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetLabelFormat_Ljava_text_NumberFormat_);
			return cb_setLabelFormat_Ljava_text_NumberFormat_;
		}

		static void n_SetLabelFormat_Ljava_text_NumberFormat_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Text.NumberFormat p0 = global::Java.Lang.Object.GetObject<global::Java.Text.NumberFormat> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.LabelFormat = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getLabelFormat;
		static IntPtr id_setLabelFormat_Ljava_text_NumberFormat_;
		public virtual global::Java.Text.NumberFormat LabelFormat {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYMultipleSeriesRenderer']/method[@name='getLabelFormat' and count(parameter)=0]"
			[Register ("getLabelFormat", "()Ljava/text/NumberFormat;", "GetGetLabelFormatHandler")]
			get {
				if (id_getLabelFormat == IntPtr.Zero)
					id_getLabelFormat = JNIEnv.GetMethodID (class_ref, "getLabelFormat", "()Ljava/text/NumberFormat;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Java.Text.NumberFormat> (JNIEnv.CallObjectMethod  (Handle, id_getLabelFormat), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Java.Text.NumberFormat> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getLabelFormat), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYMultipleSeriesRenderer']/method[@name='setLabelFormat' and count(parameter)=1 and parameter[1][@type='java.text.NumberFormat']]"
			[Register ("setLabelFormat", "(Ljava/text/NumberFormat;)V", "GetSetLabelFormat_Ljava_text_NumberFormat_Handler")]
			set {
				if (id_setLabelFormat_Ljava_text_NumberFormat_ == IntPtr.Zero)
					id_setLabelFormat_Ljava_text_NumberFormat_ = JNIEnv.GetMethodID (class_ref, "setLabelFormat", "(Ljava/text/NumberFormat;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setLabelFormat_Ljava_text_NumberFormat_, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setLabelFormat_Ljava_text_NumberFormat_, new JValue (value));
			}
		}

		static Delegate cb_getMarginsColor;
#pragma warning disable 0169
		static Delegate GetGetMarginsColorHandler ()
		{
			if (cb_getMarginsColor == null)
				cb_getMarginsColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMarginsColor);
			return cb_getMarginsColor;
		}

		static int n_GetMarginsColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MarginsColor;
		}
#pragma warning restore 0169

		static Delegate cb_setMarginsColor_I;
#pragma warning disable 0169
		static Delegate GetSetMarginsColor_IHandler ()
		{
			if (cb_setMarginsColor_I == null)
				cb_setMarginsColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetMarginsColor_I);
			return cb_setMarginsColor_I;
		}

		static void n_SetMarginsColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MarginsColor = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMarginsColor;
		static IntPtr id_setMarginsColor_I;
		public virtual int MarginsColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYMultipleSeriesRenderer']/method[@name='getMarginsColor' and count(parameter)=0]"
			[Register ("getMarginsColor", "()I", "GetGetMarginsColorHandler")]
			get {
				if (id_getMarginsColor == IntPtr.Zero)
					id_getMarginsColor = JNIEnv.GetMethodID (class_ref, "getMarginsColor", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getMarginsColor);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, id_getMarginsColor);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYMultipleSeriesRenderer']/method[@name='setMarginsColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setMarginsColor", "(I)V", "GetSetMarginsColor_IHandler")]
			set {
				if (id_setMarginsColor_I == IntPtr.Zero)
					id_setMarginsColor_I = JNIEnv.GetMethodID (class_ref, "setMarginsColor", "(I)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setMarginsColor_I, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setMarginsColor_I, new JValue (value));
			}
		}

		static Delegate cb_getPointSize;
#pragma warning disable 0169
		static Delegate GetGetPointSizeHandler ()
		{
			if (cb_getPointSize == null)
				cb_getPointSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetPointSize);
			return cb_getPointSize;
		}

		static float n_GetPointSize (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PointSize;
		}
#pragma warning restore 0169

		static Delegate cb_setPointSize_F;
#pragma warning disable 0169
		static Delegate GetSetPointSize_FHandler ()
		{
			if (cb_setPointSize_F == null)
				cb_setPointSize_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetPointSize_F);
			return cb_setPointSize_F;
		}

		static void n_SetPointSize_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PointSize = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getPointSize;
		static IntPtr id_setPointSize_F;
		public virtual float PointSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYMultipleSeriesRenderer']/method[@name='getPointSize' and count(parameter)=0]"
			[Register ("getPointSize", "()F", "GetGetPointSizeHandler")]
			get {
				if (id_getPointSize == IntPtr.Zero)
					id_getPointSize = JNIEnv.GetMethodID (class_ref, "getPointSize", "()F");

				if (GetType () == ThresholdType)
					return JNIEnv.CallFloatMethod  (Handle, id_getPointSize);
				else
					return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, id_getPointSize);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYMultipleSeriesRenderer']/method[@name='setPointSize' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setPointSize", "(F)V", "GetSetPointSize_FHandler")]
			set {
				if (id_setPointSize_F == IntPtr.Zero)
					id_setPointSize_F = JNIEnv.GetMethodID (class_ref, "setPointSize", "(F)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setPointSize_F, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setPointSize_F, new JValue (value));
			}
		}

		static Delegate cb_getScalesCount;
#pragma warning disable 0169
		static Delegate GetGetScalesCountHandler ()
		{
			if (cb_getScalesCount == null)
				cb_getScalesCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetScalesCount);
			return cb_getScalesCount;
		}

		static int n_GetScalesCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ScalesCount;
		}
#pragma warning restore 0169

		static IntPtr id_getScalesCount;
		public virtual int ScalesCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYMultipleSeriesRenderer']/method[@name='getScalesCount' and count(parameter)=0]"
			[Register ("getScalesCount", "()I", "GetGetScalesCountHandler")]
			get {
				if (id_getScalesCount == IntPtr.Zero)
					id_getScalesCount = JNIEnv.GetMethodID (class_ref, "getScalesCount", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getScalesCount);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, id_getScalesCount);
			}
		}

		static Delegate cb_getXAxisMax;
#pragma warning disable 0169
		static Delegate GetGetXAxisMaxHandler ()
		{
			if (cb_getXAxisMax == null)
				cb_getXAxisMax = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetXAxisMax);
			return cb_getXAxisMax;
		}

		static double n_GetXAxisMax (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.XAxisMax;
		}
#pragma warning restore 0169

		static Delegate cb_setXAxisMax_D;
#pragma warning disable 0169
		static Delegate GetSetXAxisMax_DHandler ()
		{
			if (cb_setXAxisMax_D == null)
				cb_setXAxisMax_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_SetXAxisMax_D);
			return cb_setXAxisMax_D;
		}

		static void n_SetXAxisMax_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.XAxisMax = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getXAxisMax;
		static IntPtr id_setXAxisMax_D;
		public virtual double XAxisMax {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYMultipleSeriesRenderer']/method[@name='getXAxisMax' and count(parameter)=0]"
			[Register ("getXAxisMax", "()D", "GetGetXAxisMaxHandler")]
			get {
				if (id_getXAxisMax == IntPtr.Zero)
					id_getXAxisMax = JNIEnv.GetMethodID (class_ref, "getXAxisMax", "()D");

				if (GetType () == ThresholdType)
					return JNIEnv.CallDoubleMethod  (Handle, id_getXAxisMax);
				else
					return JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, id_getXAxisMax);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYMultipleSeriesRenderer']/method[@name='setXAxisMax' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setXAxisMax", "(D)V", "GetSetXAxisMax_DHandler")]
			set {
				if (id_setXAxisMax_D == IntPtr.Zero)
					id_setXAxisMax_D = JNIEnv.GetMethodID (class_ref, "setXAxisMax", "(D)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setXAxisMax_D, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setXAxisMax_D, new JValue (value));
			}
		}

		static Delegate cb_getXAxisMin;
#pragma warning disable 0169
		static Delegate GetGetXAxisMinHandler ()
		{
			if (cb_getXAxisMin == null)
				cb_getXAxisMin = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetXAxisMin);
			return cb_getXAxisMin;
		}

		static double n_GetXAxisMin (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.XAxisMin;
		}
#pragma warning restore 0169

		static Delegate cb_setXAxisMin_D;
#pragma warning disable 0169
		static Delegate GetSetXAxisMin_DHandler ()
		{
			if (cb_setXAxisMin_D == null)
				cb_setXAxisMin_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_SetXAxisMin_D);
			return cb_setXAxisMin_D;
		}

		static void n_SetXAxisMin_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.XAxisMin = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getXAxisMin;
		static IntPtr id_setXAxisMin_D;
		public virtual double XAxisMin {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYMultipleSeriesRenderer']/method[@name='getXAxisMin' and count(parameter)=0]"
			[Register ("getXAxisMin", "()D", "GetGetXAxisMinHandler")]
			get {
				if (id_getXAxisMin == IntPtr.Zero)
					id_getXAxisMin = JNIEnv.GetMethodID (class_ref, "getXAxisMin", "()D");

				if (GetType () == ThresholdType)
					return JNIEnv.CallDoubleMethod  (Handle, id_getXAxisMin);
				else
					return JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, id_getXAxisMin);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYMultipleSeriesRenderer']/method[@name='setXAxisMin' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setXAxisMin", "(D)V", "GetSetXAxisMin_DHandler")]
			set {
				if (id_setXAxisMin_D == IntPtr.Zero)
					id_setXAxisMin_D = JNIEnv.GetMethodID (class_ref, "setXAxisMin", "(D)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setXAxisMin_D, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setXAxisMin_D, new JValue (value));
			}
		}

		static Delegate cb_getXLabels;
#pragma warning disable 0169
		static Delegate GetGetXLabelsHandler ()
		{
			if (cb_getXLabels == null)
				cb_getXLabels = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetXLabels);
			return cb_getXLabels;
		}

		static int n_GetXLabels (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.XLabels;
		}
#pragma warning restore 0169

		static Delegate cb_setXLabels_I;
#pragma warning disable 0169
		static Delegate GetSetXLabels_IHandler ()
		{
			if (cb_setXLabels_I == null)
				cb_setXLabels_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetXLabels_I);
			return cb_setXLabels_I;
		}

		static void n_SetXLabels_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.XLabels = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getXLabels;
		static IntPtr id_setXLabels_I;
		public virtual int XLabels {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYMultipleSeriesRenderer']/method[@name='getXLabels' and count(parameter)=0]"
			[Register ("getXLabels", "()I", "GetGetXLabelsHandler")]
			get {
				if (id_getXLabels == IntPtr.Zero)
					id_getXLabels = JNIEnv.GetMethodID (class_ref, "getXLabels", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getXLabels);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, id_getXLabels);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYMultipleSeriesRenderer']/method[@name='setXLabels' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setXLabels", "(I)V", "GetSetXLabels_IHandler")]
			set {
				if (id_setXLabels_I == IntPtr.Zero)
					id_setXLabels_I = JNIEnv.GetMethodID (class_ref, "setXLabels", "(I)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setXLabels_I, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setXLabels_I, new JValue (value));
			}
		}

		static Delegate cb_getXLabelsAlign;
#pragma warning disable 0169
		static Delegate GetGetXLabelsAlignHandler ()
		{
			if (cb_getXLabelsAlign == null)
				cb_getXLabelsAlign = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetXLabelsAlign);
			return cb_getXLabelsAlign;
		}

		static IntPtr n_GetXLabelsAlign (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.XLabelsAlign);
		}
#pragma warning restore 0169

		static Delegate cb_setXLabelsAlign_Landroid_graphics_Paint_Align_;
#pragma warning disable 0169
		static Delegate GetSetXLabelsAlign_Landroid_graphics_Paint_Align_Handler ()
		{
			if (cb_setXLabelsAlign_Landroid_graphics_Paint_Align_ == null)
				cb_setXLabelsAlign_Landroid_graphics_Paint_Align_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetXLabelsAlign_Landroid_graphics_Paint_Align_);
			return cb_setXLabelsAlign_Landroid_graphics_Paint_Align_;
		}

		static void n_SetXLabelsAlign_Landroid_graphics_Paint_Align_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Paint.Align p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint.Align> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.XLabelsAlign = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getXLabelsAlign;
		static IntPtr id_setXLabelsAlign_Landroid_graphics_Paint_Align_;
		public virtual global::Android.Graphics.Paint.Align XLabelsAlign {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYMultipleSeriesRenderer']/method[@name='getXLabelsAlign' and count(parameter)=0]"
			[Register ("getXLabelsAlign", "()Landroid/graphics/Paint$Align;", "GetGetXLabelsAlignHandler")]
			get {
				if (id_getXLabelsAlign == IntPtr.Zero)
					id_getXLabelsAlign = JNIEnv.GetMethodID (class_ref, "getXLabelsAlign", "()Landroid/graphics/Paint$Align;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint.Align> (JNIEnv.CallObjectMethod  (Handle, id_getXLabelsAlign), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint.Align> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getXLabelsAlign), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYMultipleSeriesRenderer']/method[@name='setXLabelsAlign' and count(parameter)=1 and parameter[1][@type='android.graphics.Paint.Align']]"
			[Register ("setXLabelsAlign", "(Landroid/graphics/Paint$Align;)V", "GetSetXLabelsAlign_Landroid_graphics_Paint_Align_Handler")]
			set {
				if (id_setXLabelsAlign_Landroid_graphics_Paint_Align_ == IntPtr.Zero)
					id_setXLabelsAlign_Landroid_graphics_Paint_Align_ = JNIEnv.GetMethodID (class_ref, "setXLabelsAlign", "(Landroid/graphics/Paint$Align;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setXLabelsAlign_Landroid_graphics_Paint_Align_, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setXLabelsAlign_Landroid_graphics_Paint_Align_, new JValue (value));
			}
		}

		static Delegate cb_getXLabelsAngle;
#pragma warning disable 0169
		static Delegate GetGetXLabelsAngleHandler ()
		{
			if (cb_getXLabelsAngle == null)
				cb_getXLabelsAngle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetXLabelsAngle);
			return cb_getXLabelsAngle;
		}

		static float n_GetXLabelsAngle (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.XLabelsAngle;
		}
#pragma warning restore 0169

		static Delegate cb_setXLabelsAngle_F;
#pragma warning disable 0169
		static Delegate GetSetXLabelsAngle_FHandler ()
		{
			if (cb_setXLabelsAngle_F == null)
				cb_setXLabelsAngle_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetXLabelsAngle_F);
			return cb_setXLabelsAngle_F;
		}

		static void n_SetXLabelsAngle_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.XLabelsAngle = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getXLabelsAngle;
		static IntPtr id_setXLabelsAngle_F;
		public virtual float XLabelsAngle {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYMultipleSeriesRenderer']/method[@name='getXLabelsAngle' and count(parameter)=0]"
			[Register ("getXLabelsAngle", "()F", "GetGetXLabelsAngleHandler")]
			get {
				if (id_getXLabelsAngle == IntPtr.Zero)
					id_getXLabelsAngle = JNIEnv.GetMethodID (class_ref, "getXLabelsAngle", "()F");

				if (GetType () == ThresholdType)
					return JNIEnv.CallFloatMethod  (Handle, id_getXLabelsAngle);
				else
					return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, id_getXLabelsAngle);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYMultipleSeriesRenderer']/method[@name='setXLabelsAngle' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setXLabelsAngle", "(F)V", "GetSetXLabelsAngle_FHandler")]
			set {
				if (id_setXLabelsAngle_F == IntPtr.Zero)
					id_setXLabelsAngle_F = JNIEnv.GetMethodID (class_ref, "setXLabelsAngle", "(F)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setXLabelsAngle_F, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setXLabelsAngle_F, new JValue (value));
			}
		}

		static Delegate cb_getXLabelsColor;
#pragma warning disable 0169
		static Delegate GetGetXLabelsColorHandler ()
		{
			if (cb_getXLabelsColor == null)
				cb_getXLabelsColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetXLabelsColor);
			return cb_getXLabelsColor;
		}

		static int n_GetXLabelsColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.XLabelsColor;
		}
#pragma warning restore 0169

		static Delegate cb_setXLabelsColor_I;
#pragma warning disable 0169
		static Delegate GetSetXLabelsColor_IHandler ()
		{
			if (cb_setXLabelsColor_I == null)
				cb_setXLabelsColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetXLabelsColor_I);
			return cb_setXLabelsColor_I;
		}

		static void n_SetXLabelsColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.XLabelsColor = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getXLabelsColor;
		static IntPtr id_setXLabelsColor_I;
		public virtual int XLabelsColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYMultipleSeriesRenderer']/method[@name='getXLabelsColor' and count(parameter)=0]"
			[Register ("getXLabelsColor", "()I", "GetGetXLabelsColorHandler")]
			get {
				if (id_getXLabelsColor == IntPtr.Zero)
					id_getXLabelsColor = JNIEnv.GetMethodID (class_ref, "getXLabelsColor", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getXLabelsColor);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, id_getXLabelsColor);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYMultipleSeriesRenderer']/method[@name='setXLabelsColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setXLabelsColor", "(I)V", "GetSetXLabelsColor_IHandler")]
			set {
				if (id_setXLabelsColor_I == IntPtr.Zero)
					id_setXLabelsColor_I = JNIEnv.GetMethodID (class_ref, "setXLabelsColor", "(I)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setXLabelsColor_I, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setXLabelsColor_I, new JValue (value));
			}
		}

		static Delegate cb_getXLabelsPadding;
#pragma warning disable 0169
		static Delegate GetGetXLabelsPaddingHandler ()
		{
			if (cb_getXLabelsPadding == null)
				cb_getXLabelsPadding = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetXLabelsPadding);
			return cb_getXLabelsPadding;
		}

		static float n_GetXLabelsPadding (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.XLabelsPadding;
		}
#pragma warning restore 0169

		static Delegate cb_setXLabelsPadding_F;
#pragma warning disable 0169
		static Delegate GetSetXLabelsPadding_FHandler ()
		{
			if (cb_setXLabelsPadding_F == null)
				cb_setXLabelsPadding_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetXLabelsPadding_F);
			return cb_setXLabelsPadding_F;
		}

		static void n_SetXLabelsPadding_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.XLabelsPadding = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getXLabelsPadding;
		static IntPtr id_setXLabelsPadding_F;
		public virtual float XLabelsPadding {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYMultipleSeriesRenderer']/method[@name='getXLabelsPadding' and count(parameter)=0]"
			[Register ("getXLabelsPadding", "()F", "GetGetXLabelsPaddingHandler")]
			get {
				if (id_getXLabelsPadding == IntPtr.Zero)
					id_getXLabelsPadding = JNIEnv.GetMethodID (class_ref, "getXLabelsPadding", "()F");

				if (GetType () == ThresholdType)
					return JNIEnv.CallFloatMethod  (Handle, id_getXLabelsPadding);
				else
					return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, id_getXLabelsPadding);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYMultipleSeriesRenderer']/method[@name='setXLabelsPadding' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setXLabelsPadding", "(F)V", "GetSetXLabelsPadding_FHandler")]
			set {
				if (id_setXLabelsPadding_F == IntPtr.Zero)
					id_setXLabelsPadding_F = JNIEnv.GetMethodID (class_ref, "setXLabelsPadding", "(F)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setXLabelsPadding_F, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setXLabelsPadding_F, new JValue (value));
			}
		}

		static Delegate cb_isXRoundedLabels;
#pragma warning disable 0169
		static Delegate GetIsXRoundedLabelsHandler ()
		{
			if (cb_isXRoundedLabels == null)
				cb_isXRoundedLabels = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsXRoundedLabels);
			return cb_isXRoundedLabels;
		}

		static bool n_IsXRoundedLabels (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.XRoundedLabels;
		}
#pragma warning restore 0169

		static Delegate cb_setXRoundedLabels_Z;
#pragma warning disable 0169
		static Delegate GetSetXRoundedLabels_ZHandler ()
		{
			if (cb_setXRoundedLabels_Z == null)
				cb_setXRoundedLabels_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetXRoundedLabels_Z);
			return cb_setXRoundedLabels_Z;
		}

		static void n_SetXRoundedLabels_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.XRoundedLabels = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isXRoundedLabels;
		static IntPtr id_setXRoundedLabels_Z;
		public virtual bool XRoundedLabels {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYMultipleSeriesRenderer']/method[@name='isXRoundedLabels' and count(parameter)=0]"
			[Register ("isXRoundedLabels", "()Z", "GetIsXRoundedLabelsHandler")]
			get {
				if (id_isXRoundedLabels == IntPtr.Zero)
					id_isXRoundedLabels = JNIEnv.GetMethodID (class_ref, "isXRoundedLabels", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isXRoundedLabels);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_isXRoundedLabels);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYMultipleSeriesRenderer']/method[@name='setXRoundedLabels' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setXRoundedLabels", "(Z)V", "GetSetXRoundedLabels_ZHandler")]
			set {
				if (id_setXRoundedLabels_Z == IntPtr.Zero)
					id_setXRoundedLabels_Z = JNIEnv.GetMethodID (class_ref, "setXRoundedLabels", "(Z)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setXRoundedLabels_Z, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setXRoundedLabels_Z, new JValue (value));
			}
		}

		static Delegate cb_getXTitle;
#pragma warning disable 0169
		static Delegate GetGetXTitleHandler ()
		{
			if (cb_getXTitle == null)
				cb_getXTitle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetXTitle);
			return cb_getXTitle;
		}

		static IntPtr n_GetXTitle (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.XTitle);
		}
#pragma warning restore 0169

		static Delegate cb_setXTitle_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetXTitle_Ljava_lang_String_Handler ()
		{
			if (cb_setXTitle_Ljava_lang_String_ == null)
				cb_setXTitle_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetXTitle_Ljava_lang_String_);
			return cb_setXTitle_Ljava_lang_String_;
		}

		static void n_SetXTitle_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.XTitle = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getXTitle;
		static IntPtr id_setXTitle_Ljava_lang_String_;
		public virtual string XTitle {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYMultipleSeriesRenderer']/method[@name='getXTitle' and count(parameter)=0]"
			[Register ("getXTitle", "()Ljava/lang/String;", "GetGetXTitleHandler")]
			get {
				if (id_getXTitle == IntPtr.Zero)
					id_getXTitle = JNIEnv.GetMethodID (class_ref, "getXTitle", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getXTitle), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getXTitle), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYMultipleSeriesRenderer']/method[@name='setXTitle' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setXTitle", "(Ljava/lang/String;)V", "GetSetXTitle_Ljava_lang_String_Handler")]
			set {
				if (id_setXTitle_Ljava_lang_String_ == IntPtr.Zero)
					id_setXTitle_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setXTitle", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setXTitle_Ljava_lang_String_, new JValue (native_value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setXTitle_Ljava_lang_String_, new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_getYAxisMax;
#pragma warning disable 0169
		static Delegate GetGetYAxisMaxHandler ()
		{
			if (cb_getYAxisMax == null)
				cb_getYAxisMax = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetYAxisMax);
			return cb_getYAxisMax;
		}

		static double n_GetYAxisMax (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.YAxisMax;
		}
#pragma warning restore 0169

		static Delegate cb_setYAxisMax_D;
#pragma warning disable 0169
		static Delegate GetSetYAxisMax_DHandler ()
		{
			if (cb_setYAxisMax_D == null)
				cb_setYAxisMax_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_SetYAxisMax_D);
			return cb_setYAxisMax_D;
		}

		static void n_SetYAxisMax_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.YAxisMax = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getYAxisMax;
		static IntPtr id_setYAxisMax_D;
		public virtual double YAxisMax {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYMultipleSeriesRenderer']/method[@name='getYAxisMax' and count(parameter)=0]"
			[Register ("getYAxisMax", "()D", "GetGetYAxisMaxHandler")]
			get {
				if (id_getYAxisMax == IntPtr.Zero)
					id_getYAxisMax = JNIEnv.GetMethodID (class_ref, "getYAxisMax", "()D");

				if (GetType () == ThresholdType)
					return JNIEnv.CallDoubleMethod  (Handle, id_getYAxisMax);
				else
					return JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, id_getYAxisMax);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYMultipleSeriesRenderer']/method[@name='setYAxisMax' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setYAxisMax", "(D)V", "GetSetYAxisMax_DHandler")]
			set {
				if (id_setYAxisMax_D == IntPtr.Zero)
					id_setYAxisMax_D = JNIEnv.GetMethodID (class_ref, "setYAxisMax", "(D)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setYAxisMax_D, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setYAxisMax_D, new JValue (value));
			}
		}

		static Delegate cb_getYAxisMin;
#pragma warning disable 0169
		static Delegate GetGetYAxisMinHandler ()
		{
			if (cb_getYAxisMin == null)
				cb_getYAxisMin = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetYAxisMin);
			return cb_getYAxisMin;
		}

		static double n_GetYAxisMin (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.YAxisMin;
		}
#pragma warning restore 0169

		static Delegate cb_setYAxisMin_D;
#pragma warning disable 0169
		static Delegate GetSetYAxisMin_DHandler ()
		{
			if (cb_setYAxisMin_D == null)
				cb_setYAxisMin_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_SetYAxisMin_D);
			return cb_setYAxisMin_D;
		}

		static void n_SetYAxisMin_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.YAxisMin = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getYAxisMin;
		static IntPtr id_setYAxisMin_D;
		public virtual double YAxisMin {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYMultipleSeriesRenderer']/method[@name='getYAxisMin' and count(parameter)=0]"
			[Register ("getYAxisMin", "()D", "GetGetYAxisMinHandler")]
			get {
				if (id_getYAxisMin == IntPtr.Zero)
					id_getYAxisMin = JNIEnv.GetMethodID (class_ref, "getYAxisMin", "()D");

				if (GetType () == ThresholdType)
					return JNIEnv.CallDoubleMethod  (Handle, id_getYAxisMin);
				else
					return JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, id_getYAxisMin);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYMultipleSeriesRenderer']/method[@name='setYAxisMin' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setYAxisMin", "(D)V", "GetSetYAxisMin_DHandler")]
			set {
				if (id_setYAxisMin_D == IntPtr.Zero)
					id_setYAxisMin_D = JNIEnv.GetMethodID (class_ref, "setYAxisMin", "(D)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setYAxisMin_D, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setYAxisMin_D, new JValue (value));
			}
		}

		static Delegate cb_getYLabels;
#pragma warning disable 0169
		static Delegate GetGetYLabelsHandler ()
		{
			if (cb_getYLabels == null)
				cb_getYLabels = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetYLabels);
			return cb_getYLabels;
		}

		static int n_GetYLabels (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.YLabels;
		}
#pragma warning restore 0169

		static Delegate cb_setYLabels_I;
#pragma warning disable 0169
		static Delegate GetSetYLabels_IHandler ()
		{
			if (cb_setYLabels_I == null)
				cb_setYLabels_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetYLabels_I);
			return cb_setYLabels_I;
		}

		static void n_SetYLabels_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.YLabels = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getYLabels;
		static IntPtr id_setYLabels_I;
		public virtual int YLabels {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYMultipleSeriesRenderer']/method[@name='getYLabels' and count(parameter)=0]"
			[Register ("getYLabels", "()I", "GetGetYLabelsHandler")]
			get {
				if (id_getYLabels == IntPtr.Zero)
					id_getYLabels = JNIEnv.GetMethodID (class_ref, "getYLabels", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getYLabels);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, id_getYLabels);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYMultipleSeriesRenderer']/method[@name='setYLabels' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setYLabels", "(I)V", "GetSetYLabels_IHandler")]
			set {
				if (id_setYLabels_I == IntPtr.Zero)
					id_setYLabels_I = JNIEnv.GetMethodID (class_ref, "setYLabels", "(I)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setYLabels_I, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setYLabels_I, new JValue (value));
			}
		}

		static Delegate cb_getYLabelsAngle;
#pragma warning disable 0169
		static Delegate GetGetYLabelsAngleHandler ()
		{
			if (cb_getYLabelsAngle == null)
				cb_getYLabelsAngle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetYLabelsAngle);
			return cb_getYLabelsAngle;
		}

		static float n_GetYLabelsAngle (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.YLabelsAngle;
		}
#pragma warning restore 0169

		static Delegate cb_setYLabelsAngle_F;
#pragma warning disable 0169
		static Delegate GetSetYLabelsAngle_FHandler ()
		{
			if (cb_setYLabelsAngle_F == null)
				cb_setYLabelsAngle_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetYLabelsAngle_F);
			return cb_setYLabelsAngle_F;
		}

		static void n_SetYLabelsAngle_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.YLabelsAngle = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getYLabelsAngle;
		static IntPtr id_setYLabelsAngle_F;
		public virtual float YLabelsAngle {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYMultipleSeriesRenderer']/method[@name='getYLabelsAngle' and count(parameter)=0]"
			[Register ("getYLabelsAngle", "()F", "GetGetYLabelsAngleHandler")]
			get {
				if (id_getYLabelsAngle == IntPtr.Zero)
					id_getYLabelsAngle = JNIEnv.GetMethodID (class_ref, "getYLabelsAngle", "()F");

				if (GetType () == ThresholdType)
					return JNIEnv.CallFloatMethod  (Handle, id_getYLabelsAngle);
				else
					return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, id_getYLabelsAngle);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYMultipleSeriesRenderer']/method[@name='setYLabelsAngle' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setYLabelsAngle", "(F)V", "GetSetYLabelsAngle_FHandler")]
			set {
				if (id_setYLabelsAngle_F == IntPtr.Zero)
					id_setYLabelsAngle_F = JNIEnv.GetMethodID (class_ref, "setYLabelsAngle", "(F)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setYLabelsAngle_F, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setYLabelsAngle_F, new JValue (value));
			}
		}

		static Delegate cb_getYLabelsPadding;
#pragma warning disable 0169
		static Delegate GetGetYLabelsPaddingHandler ()
		{
			if (cb_getYLabelsPadding == null)
				cb_getYLabelsPadding = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetYLabelsPadding);
			return cb_getYLabelsPadding;
		}

		static float n_GetYLabelsPadding (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.YLabelsPadding;
		}
#pragma warning restore 0169

		static Delegate cb_setYLabelsPadding_F;
#pragma warning disable 0169
		static Delegate GetSetYLabelsPadding_FHandler ()
		{
			if (cb_setYLabelsPadding_F == null)
				cb_setYLabelsPadding_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetYLabelsPadding_F);
			return cb_setYLabelsPadding_F;
		}

		static void n_SetYLabelsPadding_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.YLabelsPadding = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getYLabelsPadding;
		static IntPtr id_setYLabelsPadding_F;
		public virtual float YLabelsPadding {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYMultipleSeriesRenderer']/method[@name='getYLabelsPadding' and count(parameter)=0]"
			[Register ("getYLabelsPadding", "()F", "GetGetYLabelsPaddingHandler")]
			get {
				if (id_getYLabelsPadding == IntPtr.Zero)
					id_getYLabelsPadding = JNIEnv.GetMethodID (class_ref, "getYLabelsPadding", "()F");

				if (GetType () == ThresholdType)
					return JNIEnv.CallFloatMethod  (Handle, id_getYLabelsPadding);
				else
					return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, id_getYLabelsPadding);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYMultipleSeriesRenderer']/method[@name='setYLabelsPadding' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setYLabelsPadding", "(F)V", "GetSetYLabelsPadding_FHandler")]
			set {
				if (id_setYLabelsPadding_F == IntPtr.Zero)
					id_setYLabelsPadding_F = JNIEnv.GetMethodID (class_ref, "setYLabelsPadding", "(F)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setYLabelsPadding_F, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setYLabelsPadding_F, new JValue (value));
			}
		}

		static Delegate cb_getYLabelsVerticalPadding;
#pragma warning disable 0169
		static Delegate GetGetYLabelsVerticalPaddingHandler ()
		{
			if (cb_getYLabelsVerticalPadding == null)
				cb_getYLabelsVerticalPadding = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetYLabelsVerticalPadding);
			return cb_getYLabelsVerticalPadding;
		}

		static float n_GetYLabelsVerticalPadding (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.YLabelsVerticalPadding;
		}
#pragma warning restore 0169

		static Delegate cb_setYLabelsVerticalPadding_F;
#pragma warning disable 0169
		static Delegate GetSetYLabelsVerticalPadding_FHandler ()
		{
			if (cb_setYLabelsVerticalPadding_F == null)
				cb_setYLabelsVerticalPadding_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetYLabelsVerticalPadding_F);
			return cb_setYLabelsVerticalPadding_F;
		}

		static void n_SetYLabelsVerticalPadding_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.YLabelsVerticalPadding = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getYLabelsVerticalPadding;
		static IntPtr id_setYLabelsVerticalPadding_F;
		public virtual float YLabelsVerticalPadding {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYMultipleSeriesRenderer']/method[@name='getYLabelsVerticalPadding' and count(parameter)=0]"
			[Register ("getYLabelsVerticalPadding", "()F", "GetGetYLabelsVerticalPaddingHandler")]
			get {
				if (id_getYLabelsVerticalPadding == IntPtr.Zero)
					id_getYLabelsVerticalPadding = JNIEnv.GetMethodID (class_ref, "getYLabelsVerticalPadding", "()F");

				if (GetType () == ThresholdType)
					return JNIEnv.CallFloatMethod  (Handle, id_getYLabelsVerticalPadding);
				else
					return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, id_getYLabelsVerticalPadding);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYMultipleSeriesRenderer']/method[@name='setYLabelsVerticalPadding' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setYLabelsVerticalPadding", "(F)V", "GetSetYLabelsVerticalPadding_FHandler")]
			set {
				if (id_setYLabelsVerticalPadding_F == IntPtr.Zero)
					id_setYLabelsVerticalPadding_F = JNIEnv.GetMethodID (class_ref, "setYLabelsVerticalPadding", "(F)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setYLabelsVerticalPadding_F, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setYLabelsVerticalPadding_F, new JValue (value));
			}
		}

		static Delegate cb_getYTitle;
#pragma warning disable 0169
		static Delegate GetGetYTitleHandler ()
		{
			if (cb_getYTitle == null)
				cb_getYTitle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetYTitle);
			return cb_getYTitle;
		}

		static IntPtr n_GetYTitle (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.YTitle);
		}
#pragma warning restore 0169

		static Delegate cb_setYTitle_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetYTitle_Ljava_lang_String_Handler ()
		{
			if (cb_setYTitle_Ljava_lang_String_ == null)
				cb_setYTitle_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetYTitle_Ljava_lang_String_);
			return cb_setYTitle_Ljava_lang_String_;
		}

		static void n_SetYTitle_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.YTitle = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getYTitle;
		static IntPtr id_setYTitle_Ljava_lang_String_;
		public virtual string YTitle {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYMultipleSeriesRenderer']/method[@name='getYTitle' and count(parameter)=0]"
			[Register ("getYTitle", "()Ljava/lang/String;", "GetGetYTitleHandler")]
			get {
				if (id_getYTitle == IntPtr.Zero)
					id_getYTitle = JNIEnv.GetMethodID (class_ref, "getYTitle", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getYTitle), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getYTitle), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYMultipleSeriesRenderer']/method[@name='setYTitle' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setYTitle", "(Ljava/lang/String;)V", "GetSetYTitle_Ljava_lang_String_Handler")]
			set {
				if (id_setYTitle_Ljava_lang_String_ == IntPtr.Zero)
					id_setYTitle_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setYTitle", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setYTitle_Ljava_lang_String_, new JValue (native_value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setYTitle_Ljava_lang_String_, new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_getZoomInLimitX;
#pragma warning disable 0169
		static Delegate GetGetZoomInLimitXHandler ()
		{
			if (cb_getZoomInLimitX == null)
				cb_getZoomInLimitX = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetZoomInLimitX);
			return cb_getZoomInLimitX;
		}

		static double n_GetZoomInLimitX (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ZoomInLimitX;
		}
#pragma warning restore 0169

		static Delegate cb_setZoomInLimitX_D;
#pragma warning disable 0169
		static Delegate GetSetZoomInLimitX_DHandler ()
		{
			if (cb_setZoomInLimitX_D == null)
				cb_setZoomInLimitX_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_SetZoomInLimitX_D);
			return cb_setZoomInLimitX_D;
		}

		static void n_SetZoomInLimitX_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ZoomInLimitX = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getZoomInLimitX;
		static IntPtr id_setZoomInLimitX_D;
		public virtual double ZoomInLimitX {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYMultipleSeriesRenderer']/method[@name='getZoomInLimitX' and count(parameter)=0]"
			[Register ("getZoomInLimitX", "()D", "GetGetZoomInLimitXHandler")]
			get {
				if (id_getZoomInLimitX == IntPtr.Zero)
					id_getZoomInLimitX = JNIEnv.GetMethodID (class_ref, "getZoomInLimitX", "()D");

				if (GetType () == ThresholdType)
					return JNIEnv.CallDoubleMethod  (Handle, id_getZoomInLimitX);
				else
					return JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, id_getZoomInLimitX);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYMultipleSeriesRenderer']/method[@name='setZoomInLimitX' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setZoomInLimitX", "(D)V", "GetSetZoomInLimitX_DHandler")]
			set {
				if (id_setZoomInLimitX_D == IntPtr.Zero)
					id_setZoomInLimitX_D = JNIEnv.GetMethodID (class_ref, "setZoomInLimitX", "(D)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setZoomInLimitX_D, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setZoomInLimitX_D, new JValue (value));
			}
		}

		static Delegate cb_getZoomInLimitY;
#pragma warning disable 0169
		static Delegate GetGetZoomInLimitYHandler ()
		{
			if (cb_getZoomInLimitY == null)
				cb_getZoomInLimitY = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetZoomInLimitY);
			return cb_getZoomInLimitY;
		}

		static double n_GetZoomInLimitY (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ZoomInLimitY;
		}
#pragma warning restore 0169

		static Delegate cb_setZoomInLimitY_D;
#pragma warning disable 0169
		static Delegate GetSetZoomInLimitY_DHandler ()
		{
			if (cb_setZoomInLimitY_D == null)
				cb_setZoomInLimitY_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_SetZoomInLimitY_D);
			return cb_setZoomInLimitY_D;
		}

		static void n_SetZoomInLimitY_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ZoomInLimitY = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getZoomInLimitY;
		static IntPtr id_setZoomInLimitY_D;
		public virtual double ZoomInLimitY {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYMultipleSeriesRenderer']/method[@name='getZoomInLimitY' and count(parameter)=0]"
			[Register ("getZoomInLimitY", "()D", "GetGetZoomInLimitYHandler")]
			get {
				if (id_getZoomInLimitY == IntPtr.Zero)
					id_getZoomInLimitY = JNIEnv.GetMethodID (class_ref, "getZoomInLimitY", "()D");

				if (GetType () == ThresholdType)
					return JNIEnv.CallDoubleMethod  (Handle, id_getZoomInLimitY);
				else
					return JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, id_getZoomInLimitY);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYMultipleSeriesRenderer']/method[@name='setZoomInLimitY' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setZoomInLimitY", "(D)V", "GetSetZoomInLimitY_DHandler")]
			set {
				if (id_setZoomInLimitY_D == IntPtr.Zero)
					id_setZoomInLimitY_D = JNIEnv.GetMethodID (class_ref, "setZoomInLimitY", "(D)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setZoomInLimitY_D, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setZoomInLimitY_D, new JValue (value));
			}
		}

		static Delegate cb_addTextLabel_DLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddTextLabel_DLjava_lang_String_Handler ()
		{
			if (cb_addTextLabel_DLjava_lang_String_ == null)
				cb_addTextLabel_DLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double, IntPtr>) n_AddTextLabel_DLjava_lang_String_);
			return cb_addTextLabel_DLjava_lang_String_;
		}

		static void n_AddTextLabel_DLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, double p0, IntPtr native_p1)
		{
			global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.AddTextLabel (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_addTextLabel_DLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYMultipleSeriesRenderer']/method[@name='addTextLabel' and count(parameter)=2 and parameter[1][@type='double'] and parameter[2][@type='java.lang.String']]"
		[Register ("addTextLabel", "(DLjava/lang/String;)V", "GetAddTextLabel_DLjava_lang_String_Handler")]
		public virtual void AddTextLabel (double p0, string p1)
		{
			if (id_addTextLabel_DLjava_lang_String_ == IntPtr.Zero)
				id_addTextLabel_DLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addTextLabel", "(DLjava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_addTextLabel_DLjava_lang_String_, new JValue (p0), new JValue (native_p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_addTextLabel_DLjava_lang_String_, new JValue (p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_addXTextLabel_DLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddXTextLabel_DLjava_lang_String_Handler ()
		{
			if (cb_addXTextLabel_DLjava_lang_String_ == null)
				cb_addXTextLabel_DLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double, IntPtr>) n_AddXTextLabel_DLjava_lang_String_);
			return cb_addXTextLabel_DLjava_lang_String_;
		}

		static void n_AddXTextLabel_DLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, double p0, IntPtr native_p1)
		{
			global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.AddXTextLabel (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_addXTextLabel_DLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYMultipleSeriesRenderer']/method[@name='addXTextLabel' and count(parameter)=2 and parameter[1][@type='double'] and parameter[2][@type='java.lang.String']]"
		[Register ("addXTextLabel", "(DLjava/lang/String;)V", "GetAddXTextLabel_DLjava_lang_String_Handler")]
		public virtual void AddXTextLabel (double p0, string p1)
		{
			if (id_addXTextLabel_DLjava_lang_String_ == IntPtr.Zero)
				id_addXTextLabel_DLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addXTextLabel", "(DLjava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_addXTextLabel_DLjava_lang_String_, new JValue (p0), new JValue (native_p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_addXTextLabel_DLjava_lang_String_, new JValue (p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_addYTextLabel_DLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddYTextLabel_DLjava_lang_String_Handler ()
		{
			if (cb_addYTextLabel_DLjava_lang_String_ == null)
				cb_addYTextLabel_DLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double, IntPtr>) n_AddYTextLabel_DLjava_lang_String_);
			return cb_addYTextLabel_DLjava_lang_String_;
		}

		static void n_AddYTextLabel_DLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, double p0, IntPtr native_p1)
		{
			global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.AddYTextLabel (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_addYTextLabel_DLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYMultipleSeriesRenderer']/method[@name='addYTextLabel' and count(parameter)=2 and parameter[1][@type='double'] and parameter[2][@type='java.lang.String']]"
		[Register ("addYTextLabel", "(DLjava/lang/String;)V", "GetAddYTextLabel_DLjava_lang_String_Handler")]
		public virtual void AddYTextLabel (double p0, string p1)
		{
			if (id_addYTextLabel_DLjava_lang_String_ == IntPtr.Zero)
				id_addYTextLabel_DLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addYTextLabel", "(DLjava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_addYTextLabel_DLjava_lang_String_, new JValue (p0), new JValue (native_p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_addYTextLabel_DLjava_lang_String_, new JValue (p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_addYTextLabel_DLjava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetAddYTextLabel_DLjava_lang_String_IHandler ()
		{
			if (cb_addYTextLabel_DLjava_lang_String_I == null)
				cb_addYTextLabel_DLjava_lang_String_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double, IntPtr, int>) n_AddYTextLabel_DLjava_lang_String_I);
			return cb_addYTextLabel_DLjava_lang_String_I;
		}

		static void n_AddYTextLabel_DLjava_lang_String_I (IntPtr jnienv, IntPtr native__this, double p0, IntPtr native_p1, int p2)
		{
			global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.AddYTextLabel (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_addYTextLabel_DLjava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYMultipleSeriesRenderer']/method[@name='addYTextLabel' and count(parameter)=3 and parameter[1][@type='double'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int']]"
		[Register ("addYTextLabel", "(DLjava/lang/String;I)V", "GetAddYTextLabel_DLjava_lang_String_IHandler")]
		public virtual void AddYTextLabel (double p0, string p1, int p2)
		{
			if (id_addYTextLabel_DLjava_lang_String_I == IntPtr.Zero)
				id_addYTextLabel_DLjava_lang_String_I = JNIEnv.GetMethodID (class_ref, "addYTextLabel", "(DLjava/lang/String;I)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_addYTextLabel_DLjava_lang_String_I, new JValue (p0), new JValue (native_p1), new JValue (p2));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_addYTextLabel_DLjava_lang_String_I, new JValue (p0), new JValue (native_p1), new JValue (p2));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_clearTextLabels;
#pragma warning disable 0169
		static Delegate GetClearTextLabelsHandler ()
		{
			if (cb_clearTextLabels == null)
				cb_clearTextLabels = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ClearTextLabels);
			return cb_clearTextLabels;
		}

		static void n_ClearTextLabels (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearTextLabels ();
		}
#pragma warning restore 0169

		static IntPtr id_clearTextLabels;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYMultipleSeriesRenderer']/method[@name='clearTextLabels' and count(parameter)=0]"
		[Register ("clearTextLabels", "()V", "GetClearTextLabelsHandler")]
		public virtual void ClearTextLabels ()
		{
			if (id_clearTextLabels == IntPtr.Zero)
				id_clearTextLabels = JNIEnv.GetMethodID (class_ref, "clearTextLabels", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_clearTextLabels);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_clearTextLabels);
		}

		static Delegate cb_clearXTextLabels;
#pragma warning disable 0169
		static Delegate GetClearXTextLabelsHandler ()
		{
			if (cb_clearXTextLabels == null)
				cb_clearXTextLabels = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ClearXTextLabels);
			return cb_clearXTextLabels;
		}

		static void n_ClearXTextLabels (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearXTextLabels ();
		}
#pragma warning restore 0169

		static IntPtr id_clearXTextLabels;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYMultipleSeriesRenderer']/method[@name='clearXTextLabels' and count(parameter)=0]"
		[Register ("clearXTextLabels", "()V", "GetClearXTextLabelsHandler")]
		public virtual void ClearXTextLabels ()
		{
			if (id_clearXTextLabels == IntPtr.Zero)
				id_clearXTextLabels = JNIEnv.GetMethodID (class_ref, "clearXTextLabels", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_clearXTextLabels);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_clearXTextLabels);
		}

		static Delegate cb_clearYTextLabels;
#pragma warning disable 0169
		static Delegate GetClearYTextLabelsHandler ()
		{
			if (cb_clearYTextLabels == null)
				cb_clearYTextLabels = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ClearYTextLabels);
			return cb_clearYTextLabels;
		}

		static void n_ClearYTextLabels (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearYTextLabels ();
		}
#pragma warning restore 0169

		static IntPtr id_clearYTextLabels;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYMultipleSeriesRenderer']/method[@name='clearYTextLabels' and count(parameter)=0]"
		[Register ("clearYTextLabels", "()V", "GetClearYTextLabelsHandler")]
		public virtual void ClearYTextLabels ()
		{
			if (id_clearYTextLabels == IntPtr.Zero)
				id_clearYTextLabels = JNIEnv.GetMethodID (class_ref, "clearYTextLabels", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_clearYTextLabels);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_clearYTextLabels);
		}

		static Delegate cb_clearYTextLabels_I;
#pragma warning disable 0169
		static Delegate GetClearYTextLabels_IHandler ()
		{
			if (cb_clearYTextLabels_I == null)
				cb_clearYTextLabels_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_ClearYTextLabels_I);
			return cb_clearYTextLabels_I;
		}

		static void n_ClearYTextLabels_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearYTextLabels (p0);
		}
#pragma warning restore 0169

		static IntPtr id_clearYTextLabels_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYMultipleSeriesRenderer']/method[@name='clearYTextLabels' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("clearYTextLabels", "(I)V", "GetClearYTextLabels_IHandler")]
		public virtual void ClearYTextLabels (int p0)
		{
			if (id_clearYTextLabels_I == IntPtr.Zero)
				id_clearYTextLabels_I = JNIEnv.GetMethodID (class_ref, "clearYTextLabels", "(I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_clearYTextLabels_I, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_clearYTextLabels_I, new JValue (p0));
		}

		static Delegate cb_getInitialRange;
#pragma warning disable 0169
		static Delegate GetGetInitialRangeHandler ()
		{
			if (cb_getInitialRange == null)
				cb_getInitialRange = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetInitialRange);
			return cb_getInitialRange;
		}

		static IntPtr n_GetInitialRange (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetInitialRange ());
		}
#pragma warning restore 0169

		static IntPtr id_getInitialRange;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYMultipleSeriesRenderer']/method[@name='getInitialRange' and count(parameter)=0]"
		[Register ("getInitialRange", "()[D", "GetGetInitialRangeHandler")]
		public virtual double[] GetInitialRange ()
		{
			if (id_getInitialRange == IntPtr.Zero)
				id_getInitialRange = JNIEnv.GetMethodID (class_ref, "getInitialRange", "()[D");

			if (GetType () == ThresholdType)
				return (double[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getInitialRange), JniHandleOwnership.TransferLocalRef, typeof (double));
			else
				return (double[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getInitialRange), JniHandleOwnership.TransferLocalRef, typeof (double));
		}

		static Delegate cb_getInitialRange_I;
#pragma warning disable 0169
		static Delegate GetGetInitialRange_IHandler ()
		{
			if (cb_getInitialRange_I == null)
				cb_getInitialRange_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetInitialRange_I);
			return cb_getInitialRange_I;
		}

		static IntPtr n_GetInitialRange_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetInitialRange (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getInitialRange_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYMultipleSeriesRenderer']/method[@name='getInitialRange' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getInitialRange", "(I)[D", "GetGetInitialRange_IHandler")]
		public virtual double[] GetInitialRange (int p0)
		{
			if (id_getInitialRange_I == IntPtr.Zero)
				id_getInitialRange_I = JNIEnv.GetMethodID (class_ref, "getInitialRange", "(I)[D");

			if (GetType () == ThresholdType)
				return (double[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getInitialRange_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef, typeof (double));
			else
				return (double[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getInitialRange_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef, typeof (double));
		}

		static Delegate cb_getOrientation;
#pragma warning disable 0169
		static Delegate GetGetOrientationHandler ()
		{
			if (cb_getOrientation == null)
				cb_getOrientation = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOrientation);
			return cb_getOrientation;
		}

		static IntPtr n_GetOrientation (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetOrientation ());
		}
#pragma warning restore 0169

		static IntPtr id_getOrientation;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYMultipleSeriesRenderer']/method[@name='getOrientation' and count(parameter)=0]"
		[Register ("getOrientation", "()Lorg/achartengine/renderer/XYMultipleSeriesRenderer$Orientation;", "GetGetOrientationHandler")]
		public virtual global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer.Orientation GetOrientation ()
		{
			if (id_getOrientation == IntPtr.Zero)
				id_getOrientation = JNIEnv.GetMethodID (class_ref, "getOrientation", "()Lorg/achartengine/renderer/XYMultipleSeriesRenderer$Orientation;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer.Orientation> (JNIEnv.CallObjectMethod  (Handle, id_getOrientation), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer.Orientation> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getOrientation), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_getPanLimits;
#pragma warning disable 0169
		static Delegate GetGetPanLimitsHandler ()
		{
			if (cb_getPanLimits == null)
				cb_getPanLimits = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPanLimits);
			return cb_getPanLimits;
		}

		static IntPtr n_GetPanLimits (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetPanLimits ());
		}
#pragma warning restore 0169

		static IntPtr id_getPanLimits;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYMultipleSeriesRenderer']/method[@name='getPanLimits' and count(parameter)=0]"
		[Register ("getPanLimits", "()[D", "GetGetPanLimitsHandler")]
		public virtual double[] GetPanLimits ()
		{
			if (id_getPanLimits == IntPtr.Zero)
				id_getPanLimits = JNIEnv.GetMethodID (class_ref, "getPanLimits", "()[D");

			if (GetType () == ThresholdType)
				return (double[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getPanLimits), JniHandleOwnership.TransferLocalRef, typeof (double));
			else
				return (double[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getPanLimits), JniHandleOwnership.TransferLocalRef, typeof (double));
		}

		static Delegate cb_getXAxisMax_I;
#pragma warning disable 0169
		static Delegate GetGetXAxisMax_IHandler ()
		{
			if (cb_getXAxisMax_I == null)
				cb_getXAxisMax_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, double>) n_GetXAxisMax_I);
			return cb_getXAxisMax_I;
		}

		static double n_GetXAxisMax_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetXAxisMax (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getXAxisMax_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYMultipleSeriesRenderer']/method[@name='getXAxisMax' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getXAxisMax", "(I)D", "GetGetXAxisMax_IHandler")]
		public virtual double GetXAxisMax (int p0)
		{
			if (id_getXAxisMax_I == IntPtr.Zero)
				id_getXAxisMax_I = JNIEnv.GetMethodID (class_ref, "getXAxisMax", "(I)D");

			if (GetType () == ThresholdType)
				return JNIEnv.CallDoubleMethod  (Handle, id_getXAxisMax_I, new JValue (p0));
			else
				return JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, id_getXAxisMax_I, new JValue (p0));
		}

		static Delegate cb_getXAxisMin_I;
#pragma warning disable 0169
		static Delegate GetGetXAxisMin_IHandler ()
		{
			if (cb_getXAxisMin_I == null)
				cb_getXAxisMin_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, double>) n_GetXAxisMin_I);
			return cb_getXAxisMin_I;
		}

		static double n_GetXAxisMin_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetXAxisMin (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getXAxisMin_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYMultipleSeriesRenderer']/method[@name='getXAxisMin' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getXAxisMin", "(I)D", "GetGetXAxisMin_IHandler")]
		public virtual double GetXAxisMin (int p0)
		{
			if (id_getXAxisMin_I == IntPtr.Zero)
				id_getXAxisMin_I = JNIEnv.GetMethodID (class_ref, "getXAxisMin", "(I)D");

			if (GetType () == ThresholdType)
				return JNIEnv.CallDoubleMethod  (Handle, id_getXAxisMin_I, new JValue (p0));
			else
				return JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, id_getXAxisMin_I, new JValue (p0));
		}

		static Delegate cb_getXTextLabel_Ljava_lang_Double_;
#pragma warning disable 0169
		static Delegate GetGetXTextLabel_Ljava_lang_Double_Handler ()
		{
			if (cb_getXTextLabel_Ljava_lang_Double_ == null)
				cb_getXTextLabel_Ljava_lang_Double_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetXTextLabel_Ljava_lang_Double_);
			return cb_getXTextLabel_Ljava_lang_Double_;
		}

		static IntPtr n_GetXTextLabel_Ljava_lang_Double_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Double p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetXTextLabel (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getXTextLabel_Ljava_lang_Double_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYMultipleSeriesRenderer']/method[@name='getXTextLabel' and count(parameter)=1 and parameter[1][@type='java.lang.Double']]"
		[Register ("getXTextLabel", "(Ljava/lang/Double;)Ljava/lang/String;", "GetGetXTextLabel_Ljava_lang_Double_Handler")]
		public virtual string GetXTextLabel (global::Java.Lang.Double p0)
		{
			if (id_getXTextLabel_Ljava_lang_Double_ == IntPtr.Zero)
				id_getXTextLabel_Ljava_lang_Double_ = JNIEnv.GetMethodID (class_ref, "getXTextLabel", "(Ljava/lang/Double;)Ljava/lang/String;");

			string __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getXTextLabel_Ljava_lang_Double_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getXTextLabel_Ljava_lang_Double_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_getXTextLabelLocations;
#pragma warning disable 0169
		static Delegate GetGetXTextLabelLocationsHandler ()
		{
			if (cb_getXTextLabelLocations == null)
				cb_getXTextLabelLocations = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetXTextLabelLocations);
			return cb_getXTextLabelLocations;
		}

		static IntPtr n_GetXTextLabelLocations (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetXTextLabelLocations ());
		}
#pragma warning restore 0169

		static IntPtr id_getXTextLabelLocations;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYMultipleSeriesRenderer']/method[@name='getXTextLabelLocations' and count(parameter)=0]"
		[Register ("getXTextLabelLocations", "()[Ljava/lang/Double;", "GetGetXTextLabelLocationsHandler")]
		public virtual global::Java.Lang.Double[] GetXTextLabelLocations ()
		{
			if (id_getXTextLabelLocations == IntPtr.Zero)
				id_getXTextLabelLocations = JNIEnv.GetMethodID (class_ref, "getXTextLabelLocations", "()[Ljava/lang/Double;");

			if (GetType () == ThresholdType)
				return (global::Java.Lang.Double[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getXTextLabelLocations), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Double));
			else
				return (global::Java.Lang.Double[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getXTextLabelLocations), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Double));
		}

		static Delegate cb_getYAxisAlign_I;
#pragma warning disable 0169
		static Delegate GetGetYAxisAlign_IHandler ()
		{
			if (cb_getYAxisAlign_I == null)
				cb_getYAxisAlign_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetYAxisAlign_I);
			return cb_getYAxisAlign_I;
		}

		static IntPtr n_GetYAxisAlign_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetYAxisAlign (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getYAxisAlign_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYMultipleSeriesRenderer']/method[@name='getYAxisAlign' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getYAxisAlign", "(I)Landroid/graphics/Paint$Align;", "GetGetYAxisAlign_IHandler")]
		public virtual global::Android.Graphics.Paint.Align GetYAxisAlign (int p0)
		{
			if (id_getYAxisAlign_I == IntPtr.Zero)
				id_getYAxisAlign_I = JNIEnv.GetMethodID (class_ref, "getYAxisAlign", "(I)Landroid/graphics/Paint$Align;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint.Align> (JNIEnv.CallObjectMethod  (Handle, id_getYAxisAlign_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint.Align> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getYAxisAlign_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_getYAxisMax_I;
#pragma warning disable 0169
		static Delegate GetGetYAxisMax_IHandler ()
		{
			if (cb_getYAxisMax_I == null)
				cb_getYAxisMax_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, double>) n_GetYAxisMax_I);
			return cb_getYAxisMax_I;
		}

		static double n_GetYAxisMax_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetYAxisMax (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getYAxisMax_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYMultipleSeriesRenderer']/method[@name='getYAxisMax' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getYAxisMax", "(I)D", "GetGetYAxisMax_IHandler")]
		public virtual double GetYAxisMax (int p0)
		{
			if (id_getYAxisMax_I == IntPtr.Zero)
				id_getYAxisMax_I = JNIEnv.GetMethodID (class_ref, "getYAxisMax", "(I)D");

			if (GetType () == ThresholdType)
				return JNIEnv.CallDoubleMethod  (Handle, id_getYAxisMax_I, new JValue (p0));
			else
				return JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, id_getYAxisMax_I, new JValue (p0));
		}

		static Delegate cb_getYAxisMin_I;
#pragma warning disable 0169
		static Delegate GetGetYAxisMin_IHandler ()
		{
			if (cb_getYAxisMin_I == null)
				cb_getYAxisMin_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, double>) n_GetYAxisMin_I);
			return cb_getYAxisMin_I;
		}

		static double n_GetYAxisMin_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetYAxisMin (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getYAxisMin_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYMultipleSeriesRenderer']/method[@name='getYAxisMin' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getYAxisMin", "(I)D", "GetGetYAxisMin_IHandler")]
		public virtual double GetYAxisMin (int p0)
		{
			if (id_getYAxisMin_I == IntPtr.Zero)
				id_getYAxisMin_I = JNIEnv.GetMethodID (class_ref, "getYAxisMin", "(I)D");

			if (GetType () == ThresholdType)
				return JNIEnv.CallDoubleMethod  (Handle, id_getYAxisMin_I, new JValue (p0));
			else
				return JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, id_getYAxisMin_I, new JValue (p0));
		}

		static Delegate cb_getYLabelsAlign_I;
#pragma warning disable 0169
		static Delegate GetGetYLabelsAlign_IHandler ()
		{
			if (cb_getYLabelsAlign_I == null)
				cb_getYLabelsAlign_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetYLabelsAlign_I);
			return cb_getYLabelsAlign_I;
		}

		static IntPtr n_GetYLabelsAlign_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetYLabelsAlign (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getYLabelsAlign_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYMultipleSeriesRenderer']/method[@name='getYLabelsAlign' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getYLabelsAlign", "(I)Landroid/graphics/Paint$Align;", "GetGetYLabelsAlign_IHandler")]
		public virtual global::Android.Graphics.Paint.Align GetYLabelsAlign (int p0)
		{
			if (id_getYLabelsAlign_I == IntPtr.Zero)
				id_getYLabelsAlign_I = JNIEnv.GetMethodID (class_ref, "getYLabelsAlign", "(I)Landroid/graphics/Paint$Align;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint.Align> (JNIEnv.CallObjectMethod  (Handle, id_getYLabelsAlign_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint.Align> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getYLabelsAlign_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_getYLabelsColor_I;
#pragma warning disable 0169
		static Delegate GetGetYLabelsColor_IHandler ()
		{
			if (cb_getYLabelsColor_I == null)
				cb_getYLabelsColor_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_GetYLabelsColor_I);
			return cb_getYLabelsColor_I;
		}

		static int n_GetYLabelsColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetYLabelsColor (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getYLabelsColor_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYMultipleSeriesRenderer']/method[@name='getYLabelsColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getYLabelsColor", "(I)I", "GetGetYLabelsColor_IHandler")]
		public virtual int GetYLabelsColor (int p0)
		{
			if (id_getYLabelsColor_I == IntPtr.Zero)
				id_getYLabelsColor_I = JNIEnv.GetMethodID (class_ref, "getYLabelsColor", "(I)I");

			if (GetType () == ThresholdType)
				return JNIEnv.CallIntMethod  (Handle, id_getYLabelsColor_I, new JValue (p0));
			else
				return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, id_getYLabelsColor_I, new JValue (p0));
		}

		static Delegate cb_getYTextLabel_Ljava_lang_Double_;
#pragma warning disable 0169
		static Delegate GetGetYTextLabel_Ljava_lang_Double_Handler ()
		{
			if (cb_getYTextLabel_Ljava_lang_Double_ == null)
				cb_getYTextLabel_Ljava_lang_Double_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetYTextLabel_Ljava_lang_Double_);
			return cb_getYTextLabel_Ljava_lang_Double_;
		}

		static IntPtr n_GetYTextLabel_Ljava_lang_Double_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Double p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetYTextLabel (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getYTextLabel_Ljava_lang_Double_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYMultipleSeriesRenderer']/method[@name='getYTextLabel' and count(parameter)=1 and parameter[1][@type='java.lang.Double']]"
		[Register ("getYTextLabel", "(Ljava/lang/Double;)Ljava/lang/String;", "GetGetYTextLabel_Ljava_lang_Double_Handler")]
		public virtual string GetYTextLabel (global::Java.Lang.Double p0)
		{
			if (id_getYTextLabel_Ljava_lang_Double_ == IntPtr.Zero)
				id_getYTextLabel_Ljava_lang_Double_ = JNIEnv.GetMethodID (class_ref, "getYTextLabel", "(Ljava/lang/Double;)Ljava/lang/String;");

			string __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getYTextLabel_Ljava_lang_Double_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getYTextLabel_Ljava_lang_Double_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_getYTextLabel_Ljava_lang_Double_I;
#pragma warning disable 0169
		static Delegate GetGetYTextLabel_Ljava_lang_Double_IHandler ()
		{
			if (cb_getYTextLabel_Ljava_lang_Double_I == null)
				cb_getYTextLabel_Ljava_lang_Double_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr>) n_GetYTextLabel_Ljava_lang_Double_I);
			return cb_getYTextLabel_Ljava_lang_Double_I;
		}

		static IntPtr n_GetYTextLabel_Ljava_lang_Double_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Double p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetYTextLabel (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getYTextLabel_Ljava_lang_Double_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYMultipleSeriesRenderer']/method[@name='getYTextLabel' and count(parameter)=2 and parameter[1][@type='java.lang.Double'] and parameter[2][@type='int']]"
		[Register ("getYTextLabel", "(Ljava/lang/Double;I)Ljava/lang/String;", "GetGetYTextLabel_Ljava_lang_Double_IHandler")]
		public virtual string GetYTextLabel (global::Java.Lang.Double p0, int p1)
		{
			if (id_getYTextLabel_Ljava_lang_Double_I == IntPtr.Zero)
				id_getYTextLabel_Ljava_lang_Double_I = JNIEnv.GetMethodID (class_ref, "getYTextLabel", "(Ljava/lang/Double;I)Ljava/lang/String;");

			string __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getYTextLabel_Ljava_lang_Double_I, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getYTextLabel_Ljava_lang_Double_I, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_getYTextLabelLocations;
#pragma warning disable 0169
		static Delegate GetGetYTextLabelLocationsHandler ()
		{
			if (cb_getYTextLabelLocations == null)
				cb_getYTextLabelLocations = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetYTextLabelLocations);
			return cb_getYTextLabelLocations;
		}

		static IntPtr n_GetYTextLabelLocations (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetYTextLabelLocations ());
		}
#pragma warning restore 0169

		static IntPtr id_getYTextLabelLocations;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYMultipleSeriesRenderer']/method[@name='getYTextLabelLocations' and count(parameter)=0]"
		[Register ("getYTextLabelLocations", "()[Ljava/lang/Double;", "GetGetYTextLabelLocationsHandler")]
		public virtual global::Java.Lang.Double[] GetYTextLabelLocations ()
		{
			if (id_getYTextLabelLocations == IntPtr.Zero)
				id_getYTextLabelLocations = JNIEnv.GetMethodID (class_ref, "getYTextLabelLocations", "()[Ljava/lang/Double;");

			if (GetType () == ThresholdType)
				return (global::Java.Lang.Double[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getYTextLabelLocations), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Double));
			else
				return (global::Java.Lang.Double[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getYTextLabelLocations), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Double));
		}

		static Delegate cb_getYTextLabelLocations_I;
#pragma warning disable 0169
		static Delegate GetGetYTextLabelLocations_IHandler ()
		{
			if (cb_getYTextLabelLocations_I == null)
				cb_getYTextLabelLocations_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetYTextLabelLocations_I);
			return cb_getYTextLabelLocations_I;
		}

		static IntPtr n_GetYTextLabelLocations_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetYTextLabelLocations (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getYTextLabelLocations_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYMultipleSeriesRenderer']/method[@name='getYTextLabelLocations' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getYTextLabelLocations", "(I)[Ljava/lang/Double;", "GetGetYTextLabelLocations_IHandler")]
		public virtual global::Java.Lang.Double[] GetYTextLabelLocations (int p0)
		{
			if (id_getYTextLabelLocations_I == IntPtr.Zero)
				id_getYTextLabelLocations_I = JNIEnv.GetMethodID (class_ref, "getYTextLabelLocations", "(I)[Ljava/lang/Double;");

			if (GetType () == ThresholdType)
				return (global::Java.Lang.Double[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getYTextLabelLocations_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Double));
			else
				return (global::Java.Lang.Double[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getYTextLabelLocations_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Double));
		}

		static Delegate cb_getYTitle_I;
#pragma warning disable 0169
		static Delegate GetGetYTitle_IHandler ()
		{
			if (cb_getYTitle_I == null)
				cb_getYTitle_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetYTitle_I);
			return cb_getYTitle_I;
		}

		static IntPtr n_GetYTitle_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GetYTitle (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getYTitle_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYMultipleSeriesRenderer']/method[@name='getYTitle' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getYTitle", "(I)Ljava/lang/String;", "GetGetYTitle_IHandler")]
		public virtual string GetYTitle (int p0)
		{
			if (id_getYTitle_I == IntPtr.Zero)
				id_getYTitle_I = JNIEnv.GetMethodID (class_ref, "getYTitle", "(I)Ljava/lang/String;");

			if (GetType () == ThresholdType)
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getYTitle_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getYTitle_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_getZoomLimits;
#pragma warning disable 0169
		static Delegate GetGetZoomLimitsHandler ()
		{
			if (cb_getZoomLimits == null)
				cb_getZoomLimits = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetZoomLimits);
			return cb_getZoomLimits;
		}

		static IntPtr n_GetZoomLimits (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetZoomLimits ());
		}
#pragma warning restore 0169

		static IntPtr id_getZoomLimits;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYMultipleSeriesRenderer']/method[@name='getZoomLimits' and count(parameter)=0]"
		[Register ("getZoomLimits", "()[D", "GetGetZoomLimitsHandler")]
		public virtual double[] GetZoomLimits ()
		{
			if (id_getZoomLimits == IntPtr.Zero)
				id_getZoomLimits = JNIEnv.GetMethodID (class_ref, "getZoomLimits", "()[D");

			if (GetType () == ThresholdType)
				return (double[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getZoomLimits), JniHandleOwnership.TransferLocalRef, typeof (double));
			else
				return (double[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getZoomLimits), JniHandleOwnership.TransferLocalRef, typeof (double));
		}

		static Delegate cb_initAxesRange_I;
#pragma warning disable 0169
		static Delegate GetInitAxesRange_IHandler ()
		{
			if (cb_initAxesRange_I == null)
				cb_initAxesRange_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_InitAxesRange_I);
			return cb_initAxesRange_I;
		}

		static void n_InitAxesRange_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.InitAxesRange (p0);
		}
#pragma warning restore 0169

		static IntPtr id_initAxesRange_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYMultipleSeriesRenderer']/method[@name='initAxesRange' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("initAxesRange", "(I)V", "GetInitAxesRange_IHandler")]
		public virtual void InitAxesRange (int p0)
		{
			if (id_initAxesRange_I == IntPtr.Zero)
				id_initAxesRange_I = JNIEnv.GetMethodID (class_ref, "initAxesRange", "(I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_initAxesRange_I, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_initAxesRange_I, new JValue (p0));
		}

		static Delegate cb_initAxesRangeForScale_I;
#pragma warning disable 0169
		static Delegate GetInitAxesRangeForScale_IHandler ()
		{
			if (cb_initAxesRangeForScale_I == null)
				cb_initAxesRangeForScale_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_InitAxesRangeForScale_I);
			return cb_initAxesRangeForScale_I;
		}

		static void n_InitAxesRangeForScale_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.InitAxesRangeForScale (p0);
		}
#pragma warning restore 0169

		static IntPtr id_initAxesRangeForScale_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYMultipleSeriesRenderer']/method[@name='initAxesRangeForScale' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("initAxesRangeForScale", "(I)V", "GetInitAxesRangeForScale_IHandler")]
		public virtual void InitAxesRangeForScale (int p0)
		{
			if (id_initAxesRangeForScale_I == IntPtr.Zero)
				id_initAxesRangeForScale_I = JNIEnv.GetMethodID (class_ref, "initAxesRangeForScale", "(I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_initAxesRangeForScale_I, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_initAxesRangeForScale_I, new JValue (p0));
		}

		static Delegate cb_isInitialRangeSet_I;
#pragma warning disable 0169
		static Delegate GetInvokeIsInitialRangeSet_IHandler ()
		{
			if (cb_isInitialRangeSet_I == null)
				cb_isInitialRangeSet_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_InvokeIsInitialRangeSet_I);
			return cb_isInitialRangeSet_I;
		}

		static bool n_InvokeIsInitialRangeSet_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.InvokeIsInitialRangeSet (p0);
		}
#pragma warning restore 0169

		static IntPtr id_isInitialRangeSet_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYMultipleSeriesRenderer']/method[@name='isInitialRangeSet' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("isInitialRangeSet", "(I)Z", "GetInvokeIsInitialRangeSet_IHandler")]
		public virtual bool InvokeIsInitialRangeSet (int p0)
		{
			if (id_isInitialRangeSet_I == IntPtr.Zero)
				id_isInitialRangeSet_I = JNIEnv.GetMethodID (class_ref, "isInitialRangeSet", "(I)Z");

			if (GetType () == ThresholdType)
				return JNIEnv.CallBooleanMethod  (Handle, id_isInitialRangeSet_I, new JValue (p0));
			else
				return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_isInitialRangeSet_I, new JValue (p0));
		}

		static Delegate cb_isMaxXSet_I;
#pragma warning disable 0169
		static Delegate GetInvokeIsMaxXSet_IHandler ()
		{
			if (cb_isMaxXSet_I == null)
				cb_isMaxXSet_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_InvokeIsMaxXSet_I);
			return cb_isMaxXSet_I;
		}

		static bool n_InvokeIsMaxXSet_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.InvokeIsMaxXSet (p0);
		}
#pragma warning restore 0169

		static IntPtr id_isMaxXSet_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYMultipleSeriesRenderer']/method[@name='isMaxXSet' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("isMaxXSet", "(I)Z", "GetInvokeIsMaxXSet_IHandler")]
		public virtual bool InvokeIsMaxXSet (int p0)
		{
			if (id_isMaxXSet_I == IntPtr.Zero)
				id_isMaxXSet_I = JNIEnv.GetMethodID (class_ref, "isMaxXSet", "(I)Z");

			if (GetType () == ThresholdType)
				return JNIEnv.CallBooleanMethod  (Handle, id_isMaxXSet_I, new JValue (p0));
			else
				return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_isMaxXSet_I, new JValue (p0));
		}

		static Delegate cb_isMaxYSet_I;
#pragma warning disable 0169
		static Delegate GetInvokeIsMaxYSet_IHandler ()
		{
			if (cb_isMaxYSet_I == null)
				cb_isMaxYSet_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_InvokeIsMaxYSet_I);
			return cb_isMaxYSet_I;
		}

		static bool n_InvokeIsMaxYSet_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.InvokeIsMaxYSet (p0);
		}
#pragma warning restore 0169

		static IntPtr id_isMaxYSet_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYMultipleSeriesRenderer']/method[@name='isMaxYSet' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("isMaxYSet", "(I)Z", "GetInvokeIsMaxYSet_IHandler")]
		public virtual bool InvokeIsMaxYSet (int p0)
		{
			if (id_isMaxYSet_I == IntPtr.Zero)
				id_isMaxYSet_I = JNIEnv.GetMethodID (class_ref, "isMaxYSet", "(I)Z");

			if (GetType () == ThresholdType)
				return JNIEnv.CallBooleanMethod  (Handle, id_isMaxYSet_I, new JValue (p0));
			else
				return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_isMaxYSet_I, new JValue (p0));
		}

		static Delegate cb_isMinXSet_I;
#pragma warning disable 0169
		static Delegate GetInvokeIsMinXSet_IHandler ()
		{
			if (cb_isMinXSet_I == null)
				cb_isMinXSet_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_InvokeIsMinXSet_I);
			return cb_isMinXSet_I;
		}

		static bool n_InvokeIsMinXSet_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.InvokeIsMinXSet (p0);
		}
#pragma warning restore 0169

		static IntPtr id_isMinXSet_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYMultipleSeriesRenderer']/method[@name='isMinXSet' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("isMinXSet", "(I)Z", "GetInvokeIsMinXSet_IHandler")]
		public virtual bool InvokeIsMinXSet (int p0)
		{
			if (id_isMinXSet_I == IntPtr.Zero)
				id_isMinXSet_I = JNIEnv.GetMethodID (class_ref, "isMinXSet", "(I)Z");

			if (GetType () == ThresholdType)
				return JNIEnv.CallBooleanMethod  (Handle, id_isMinXSet_I, new JValue (p0));
			else
				return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_isMinXSet_I, new JValue (p0));
		}

		static Delegate cb_isMinYSet_I;
#pragma warning disable 0169
		static Delegate GetInvokeIsMinYSet_IHandler ()
		{
			if (cb_isMinYSet_I == null)
				cb_isMinYSet_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_InvokeIsMinYSet_I);
			return cb_isMinYSet_I;
		}

		static bool n_InvokeIsMinYSet_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.InvokeIsMinYSet (p0);
		}
#pragma warning restore 0169

		static IntPtr id_isMinYSet_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYMultipleSeriesRenderer']/method[@name='isMinYSet' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("isMinYSet", "(I)Z", "GetInvokeIsMinYSet_IHandler")]
		public virtual bool InvokeIsMinYSet (int p0)
		{
			if (id_isMinYSet_I == IntPtr.Zero)
				id_isMinYSet_I = JNIEnv.GetMethodID (class_ref, "isMinYSet", "(I)Z");

			if (GetType () == ThresholdType)
				return JNIEnv.CallBooleanMethod  (Handle, id_isMinYSet_I, new JValue (p0));
			else
				return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_isMinYSet_I, new JValue (p0));
		}

		static Delegate cb_removeXTextLabel_D;
#pragma warning disable 0169
		static Delegate GetRemoveXTextLabel_DHandler ()
		{
			if (cb_removeXTextLabel_D == null)
				cb_removeXTextLabel_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_RemoveXTextLabel_D);
			return cb_removeXTextLabel_D;
		}

		static void n_RemoveXTextLabel_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RemoveXTextLabel (p0);
		}
#pragma warning restore 0169

		static IntPtr id_removeXTextLabel_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYMultipleSeriesRenderer']/method[@name='removeXTextLabel' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("removeXTextLabel", "(D)V", "GetRemoveXTextLabel_DHandler")]
		public virtual void RemoveXTextLabel (double p0)
		{
			if (id_removeXTextLabel_D == IntPtr.Zero)
				id_removeXTextLabel_D = JNIEnv.GetMethodID (class_ref, "removeXTextLabel", "(D)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_removeXTextLabel_D, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_removeXTextLabel_D, new JValue (p0));
		}

		static Delegate cb_removeYTextLabel_D;
#pragma warning disable 0169
		static Delegate GetRemoveYTextLabel_DHandler ()
		{
			if (cb_removeYTextLabel_D == null)
				cb_removeYTextLabel_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_RemoveYTextLabel_D);
			return cb_removeYTextLabel_D;
		}

		static void n_RemoveYTextLabel_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RemoveYTextLabel (p0);
		}
#pragma warning restore 0169

		static IntPtr id_removeYTextLabel_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYMultipleSeriesRenderer']/method[@name='removeYTextLabel' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("removeYTextLabel", "(D)V", "GetRemoveYTextLabel_DHandler")]
		public virtual void RemoveYTextLabel (double p0)
		{
			if (id_removeYTextLabel_D == IntPtr.Zero)
				id_removeYTextLabel_D = JNIEnv.GetMethodID (class_ref, "removeYTextLabel", "(D)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_removeYTextLabel_D, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_removeYTextLabel_D, new JValue (p0));
		}

		static Delegate cb_removeYTextLabel_DI;
#pragma warning disable 0169
		static Delegate GetRemoveYTextLabel_DIHandler ()
		{
			if (cb_removeYTextLabel_DI == null)
				cb_removeYTextLabel_DI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double, int>) n_RemoveYTextLabel_DI);
			return cb_removeYTextLabel_DI;
		}

		static void n_RemoveYTextLabel_DI (IntPtr jnienv, IntPtr native__this, double p0, int p1)
		{
			global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RemoveYTextLabel (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_removeYTextLabel_DI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYMultipleSeriesRenderer']/method[@name='removeYTextLabel' and count(parameter)=2 and parameter[1][@type='double'] and parameter[2][@type='int']]"
		[Register ("removeYTextLabel", "(DI)V", "GetRemoveYTextLabel_DIHandler")]
		public virtual void RemoveYTextLabel (double p0, int p1)
		{
			if (id_removeYTextLabel_DI == IntPtr.Zero)
				id_removeYTextLabel_DI = JNIEnv.GetMethodID (class_ref, "removeYTextLabel", "(DI)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_removeYTextLabel_DI, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_removeYTextLabel_DI, new JValue (p0), new JValue (p1));
		}

		static Delegate cb_setChartValuesTextSize_F;
#pragma warning disable 0169
		static Delegate GetSetChartValuesTextSize_FHandler ()
		{
			if (cb_setChartValuesTextSize_F == null)
				cb_setChartValuesTextSize_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetChartValuesTextSize_F);
			return cb_setChartValuesTextSize_F;
		}

		static void n_SetChartValuesTextSize_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetChartValuesTextSize (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setChartValuesTextSize_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYMultipleSeriesRenderer']/method[@name='setChartValuesTextSize' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setChartValuesTextSize", "(F)V", "GetSetChartValuesTextSize_FHandler")]
		public virtual void SetChartValuesTextSize (float p0)
		{
			if (id_setChartValuesTextSize_F == IntPtr.Zero)
				id_setChartValuesTextSize_F = JNIEnv.GetMethodID (class_ref, "setChartValuesTextSize", "(F)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setChartValuesTextSize_F, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setChartValuesTextSize_F, new JValue (p0));
		}

		static Delegate cb_setDisplayChartValues_Z;
#pragma warning disable 0169
		static Delegate GetSetDisplayChartValues_ZHandler ()
		{
			if (cb_setDisplayChartValues_Z == null)
				cb_setDisplayChartValues_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetDisplayChartValues_Z);
			return cb_setDisplayChartValues_Z;
		}

		static void n_SetDisplayChartValues_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDisplayChartValues (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setDisplayChartValues_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYMultipleSeriesRenderer']/method[@name='setDisplayChartValues' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setDisplayChartValues", "(Z)V", "GetSetDisplayChartValues_ZHandler")]
		public virtual void SetDisplayChartValues (bool p0)
		{
			if (id_setDisplayChartValues_Z == IntPtr.Zero)
				id_setDisplayChartValues_Z = JNIEnv.GetMethodID (class_ref, "setDisplayChartValues", "(Z)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setDisplayChartValues_Z, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setDisplayChartValues_Z, new JValue (p0));
		}

		static Delegate cb_setInitialRange_arrayD;
#pragma warning disable 0169
		static Delegate GetSetInitialRange_arrayDHandler ()
		{
			if (cb_setInitialRange_arrayD == null)
				cb_setInitialRange_arrayD = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetInitialRange_arrayD);
			return cb_setInitialRange_arrayD;
		}

		static void n_SetInitialRange_arrayD (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			double[] p0 = (double[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (double));
			__this.SetInitialRange (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_setInitialRange_arrayD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYMultipleSeriesRenderer']/method[@name='setInitialRange' and count(parameter)=1 and parameter[1][@type='double[]']]"
		[Register ("setInitialRange", "([D)V", "GetSetInitialRange_arrayDHandler")]
		public virtual void SetInitialRange (double[] p0)
		{
			if (id_setInitialRange_arrayD == IntPtr.Zero)
				id_setInitialRange_arrayD = JNIEnv.GetMethodID (class_ref, "setInitialRange", "([D)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setInitialRange_arrayD, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setInitialRange_arrayD, new JValue (native_p0));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setInitialRange_arrayDI;
#pragma warning disable 0169
		static Delegate GetSetInitialRange_arrayDIHandler ()
		{
			if (cb_setInitialRange_arrayDI == null)
				cb_setInitialRange_arrayDI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_SetInitialRange_arrayDI);
			return cb_setInitialRange_arrayDI;
		}

		static void n_SetInitialRange_arrayDI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			double[] p0 = (double[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (double));
			__this.SetInitialRange (p0, p1);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_setInitialRange_arrayDI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYMultipleSeriesRenderer']/method[@name='setInitialRange' and count(parameter)=2 and parameter[1][@type='double[]'] and parameter[2][@type='int']]"
		[Register ("setInitialRange", "([DI)V", "GetSetInitialRange_arrayDIHandler")]
		public virtual void SetInitialRange (double[] p0, int p1)
		{
			if (id_setInitialRange_arrayDI == IntPtr.Zero)
				id_setInitialRange_arrayDI = JNIEnv.GetMethodID (class_ref, "setInitialRange", "([DI)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setInitialRange_arrayDI, new JValue (native_p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setInitialRange_arrayDI, new JValue (native_p0), new JValue (p1));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setOrientation_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_Orientation_;
#pragma warning disable 0169
		static Delegate GetSetOrientation_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_Orientation_Handler ()
		{
			if (cb_setOrientation_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_Orientation_ == null)
				cb_setOrientation_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_Orientation_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOrientation_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_Orientation_);
			return cb_setOrientation_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_Orientation_;
		}

		static void n_SetOrientation_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_Orientation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer.Orientation p0 = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer.Orientation> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOrientation (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOrientation_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_Orientation_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYMultipleSeriesRenderer']/method[@name='setOrientation' and count(parameter)=1 and parameter[1][@type='org.achartengine.renderer.XYMultipleSeriesRenderer.Orientation']]"
		[Register ("setOrientation", "(Lorg/achartengine/renderer/XYMultipleSeriesRenderer$Orientation;)V", "GetSetOrientation_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_Orientation_Handler")]
		public virtual void SetOrientation (global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer.Orientation p0)
		{
			if (id_setOrientation_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_Orientation_ == IntPtr.Zero)
				id_setOrientation_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_Orientation_ = JNIEnv.GetMethodID (class_ref, "setOrientation", "(Lorg/achartengine/renderer/XYMultipleSeriesRenderer$Orientation;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setOrientation_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_Orientation_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setOrientation_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_Orientation_, new JValue (p0));
		}

		static Delegate cb_setPanEnabled_ZZ;
#pragma warning disable 0169
		static Delegate GetSetPanEnabled_ZZHandler ()
		{
			if (cb_setPanEnabled_ZZ == null)
				cb_setPanEnabled_ZZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool, bool>) n_SetPanEnabled_ZZ);
			return cb_setPanEnabled_ZZ;
		}

		static void n_SetPanEnabled_ZZ (IntPtr jnienv, IntPtr native__this, bool p0, bool p1)
		{
			global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetPanEnabled (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setPanEnabled_ZZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYMultipleSeriesRenderer']/method[@name='setPanEnabled' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='boolean']]"
		[Register ("setPanEnabled", "(ZZ)V", "GetSetPanEnabled_ZZHandler")]
		public virtual void SetPanEnabled (bool p0, bool p1)
		{
			if (id_setPanEnabled_ZZ == IntPtr.Zero)
				id_setPanEnabled_ZZ = JNIEnv.GetMethodID (class_ref, "setPanEnabled", "(ZZ)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setPanEnabled_ZZ, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setPanEnabled_ZZ, new JValue (p0), new JValue (p1));
		}

		static Delegate cb_setPanLimits_arrayD;
#pragma warning disable 0169
		static Delegate GetSetPanLimits_arrayDHandler ()
		{
			if (cb_setPanLimits_arrayD == null)
				cb_setPanLimits_arrayD = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPanLimits_arrayD);
			return cb_setPanLimits_arrayD;
		}

		static void n_SetPanLimits_arrayD (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			double[] p0 = (double[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (double));
			__this.SetPanLimits (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_setPanLimits_arrayD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYMultipleSeriesRenderer']/method[@name='setPanLimits' and count(parameter)=1 and parameter[1][@type='double[]']]"
		[Register ("setPanLimits", "([D)V", "GetSetPanLimits_arrayDHandler")]
		public virtual void SetPanLimits (double[] p0)
		{
			if (id_setPanLimits_arrayD == IntPtr.Zero)
				id_setPanLimits_arrayD = JNIEnv.GetMethodID (class_ref, "setPanLimits", "([D)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setPanLimits_arrayD, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setPanLimits_arrayD, new JValue (native_p0));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setRange_arrayD;
#pragma warning disable 0169
		static Delegate GetSetRange_arrayDHandler ()
		{
			if (cb_setRange_arrayD == null)
				cb_setRange_arrayD = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetRange_arrayD);
			return cb_setRange_arrayD;
		}

		static void n_SetRange_arrayD (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			double[] p0 = (double[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (double));
			__this.SetRange (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_setRange_arrayD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYMultipleSeriesRenderer']/method[@name='setRange' and count(parameter)=1 and parameter[1][@type='double[]']]"
		[Register ("setRange", "([D)V", "GetSetRange_arrayDHandler")]
		public virtual void SetRange (double[] p0)
		{
			if (id_setRange_arrayD == IntPtr.Zero)
				id_setRange_arrayD = JNIEnv.GetMethodID (class_ref, "setRange", "([D)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setRange_arrayD, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setRange_arrayD, new JValue (native_p0));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setRange_arrayDI;
#pragma warning disable 0169
		static Delegate GetSetRange_arrayDIHandler ()
		{
			if (cb_setRange_arrayDI == null)
				cb_setRange_arrayDI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_SetRange_arrayDI);
			return cb_setRange_arrayDI;
		}

		static void n_SetRange_arrayDI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			double[] p0 = (double[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (double));
			__this.SetRange (p0, p1);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_setRange_arrayDI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYMultipleSeriesRenderer']/method[@name='setRange' and count(parameter)=2 and parameter[1][@type='double[]'] and parameter[2][@type='int']]"
		[Register ("setRange", "([DI)V", "GetSetRange_arrayDIHandler")]
		public virtual void SetRange (double[] p0, int p1)
		{
			if (id_setRange_arrayDI == IntPtr.Zero)
				id_setRange_arrayDI = JNIEnv.GetMethodID (class_ref, "setRange", "([DI)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setRange_arrayDI, new JValue (native_p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setRange_arrayDI, new JValue (native_p0), new JValue (p1));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setXAxisMax_DI;
#pragma warning disable 0169
		static Delegate GetSetXAxisMax_DIHandler ()
		{
			if (cb_setXAxisMax_DI == null)
				cb_setXAxisMax_DI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double, int>) n_SetXAxisMax_DI);
			return cb_setXAxisMax_DI;
		}

		static void n_SetXAxisMax_DI (IntPtr jnienv, IntPtr native__this, double p0, int p1)
		{
			global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetXAxisMax (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setXAxisMax_DI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYMultipleSeriesRenderer']/method[@name='setXAxisMax' and count(parameter)=2 and parameter[1][@type='double'] and parameter[2][@type='int']]"
		[Register ("setXAxisMax", "(DI)V", "GetSetXAxisMax_DIHandler")]
		public virtual void SetXAxisMax (double p0, int p1)
		{
			if (id_setXAxisMax_DI == IntPtr.Zero)
				id_setXAxisMax_DI = JNIEnv.GetMethodID (class_ref, "setXAxisMax", "(DI)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setXAxisMax_DI, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setXAxisMax_DI, new JValue (p0), new JValue (p1));
		}

		static Delegate cb_setXAxisMin_DI;
#pragma warning disable 0169
		static Delegate GetSetXAxisMin_DIHandler ()
		{
			if (cb_setXAxisMin_DI == null)
				cb_setXAxisMin_DI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double, int>) n_SetXAxisMin_DI);
			return cb_setXAxisMin_DI;
		}

		static void n_SetXAxisMin_DI (IntPtr jnienv, IntPtr native__this, double p0, int p1)
		{
			global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetXAxisMin (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setXAxisMin_DI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYMultipleSeriesRenderer']/method[@name='setXAxisMin' and count(parameter)=2 and parameter[1][@type='double'] and parameter[2][@type='int']]"
		[Register ("setXAxisMin", "(DI)V", "GetSetXAxisMin_DIHandler")]
		public virtual void SetXAxisMin (double p0, int p1)
		{
			if (id_setXAxisMin_DI == IntPtr.Zero)
				id_setXAxisMin_DI = JNIEnv.GetMethodID (class_ref, "setXAxisMin", "(DI)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setXAxisMin_DI, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setXAxisMin_DI, new JValue (p0), new JValue (p1));
		}

		static Delegate cb_setYAxisAlign_Landroid_graphics_Paint_Align_I;
#pragma warning disable 0169
		static Delegate GetSetYAxisAlign_Landroid_graphics_Paint_Align_IHandler ()
		{
			if (cb_setYAxisAlign_Landroid_graphics_Paint_Align_I == null)
				cb_setYAxisAlign_Landroid_graphics_Paint_Align_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_SetYAxisAlign_Landroid_graphics_Paint_Align_I);
			return cb_setYAxisAlign_Landroid_graphics_Paint_Align_I;
		}

		static void n_SetYAxisAlign_Landroid_graphics_Paint_Align_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Paint.Align p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint.Align> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetYAxisAlign (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setYAxisAlign_Landroid_graphics_Paint_Align_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYMultipleSeriesRenderer']/method[@name='setYAxisAlign' and count(parameter)=2 and parameter[1][@type='android.graphics.Paint.Align'] and parameter[2][@type='int']]"
		[Register ("setYAxisAlign", "(Landroid/graphics/Paint$Align;I)V", "GetSetYAxisAlign_Landroid_graphics_Paint_Align_IHandler")]
		public virtual void SetYAxisAlign (global::Android.Graphics.Paint.Align p0, int p1)
		{
			if (id_setYAxisAlign_Landroid_graphics_Paint_Align_I == IntPtr.Zero)
				id_setYAxisAlign_Landroid_graphics_Paint_Align_I = JNIEnv.GetMethodID (class_ref, "setYAxisAlign", "(Landroid/graphics/Paint$Align;I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setYAxisAlign_Landroid_graphics_Paint_Align_I, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setYAxisAlign_Landroid_graphics_Paint_Align_I, new JValue (p0), new JValue (p1));
		}

		static Delegate cb_setYAxisMax_DI;
#pragma warning disable 0169
		static Delegate GetSetYAxisMax_DIHandler ()
		{
			if (cb_setYAxisMax_DI == null)
				cb_setYAxisMax_DI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double, int>) n_SetYAxisMax_DI);
			return cb_setYAxisMax_DI;
		}

		static void n_SetYAxisMax_DI (IntPtr jnienv, IntPtr native__this, double p0, int p1)
		{
			global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetYAxisMax (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setYAxisMax_DI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYMultipleSeriesRenderer']/method[@name='setYAxisMax' and count(parameter)=2 and parameter[1][@type='double'] and parameter[2][@type='int']]"
		[Register ("setYAxisMax", "(DI)V", "GetSetYAxisMax_DIHandler")]
		public virtual void SetYAxisMax (double p0, int p1)
		{
			if (id_setYAxisMax_DI == IntPtr.Zero)
				id_setYAxisMax_DI = JNIEnv.GetMethodID (class_ref, "setYAxisMax", "(DI)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setYAxisMax_DI, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setYAxisMax_DI, new JValue (p0), new JValue (p1));
		}

		static Delegate cb_setYAxisMin_DI;
#pragma warning disable 0169
		static Delegate GetSetYAxisMin_DIHandler ()
		{
			if (cb_setYAxisMin_DI == null)
				cb_setYAxisMin_DI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double, int>) n_SetYAxisMin_DI);
			return cb_setYAxisMin_DI;
		}

		static void n_SetYAxisMin_DI (IntPtr jnienv, IntPtr native__this, double p0, int p1)
		{
			global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetYAxisMin (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setYAxisMin_DI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYMultipleSeriesRenderer']/method[@name='setYAxisMin' and count(parameter)=2 and parameter[1][@type='double'] and parameter[2][@type='int']]"
		[Register ("setYAxisMin", "(DI)V", "GetSetYAxisMin_DIHandler")]
		public virtual void SetYAxisMin (double p0, int p1)
		{
			if (id_setYAxisMin_DI == IntPtr.Zero)
				id_setYAxisMin_DI = JNIEnv.GetMethodID (class_ref, "setYAxisMin", "(DI)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setYAxisMin_DI, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setYAxisMin_DI, new JValue (p0), new JValue (p1));
		}

		static Delegate cb_setYLabelsAlign_Landroid_graphics_Paint_Align_;
#pragma warning disable 0169
		static Delegate GetSetYLabelsAlign_Landroid_graphics_Paint_Align_Handler ()
		{
			if (cb_setYLabelsAlign_Landroid_graphics_Paint_Align_ == null)
				cb_setYLabelsAlign_Landroid_graphics_Paint_Align_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetYLabelsAlign_Landroid_graphics_Paint_Align_);
			return cb_setYLabelsAlign_Landroid_graphics_Paint_Align_;
		}

		static void n_SetYLabelsAlign_Landroid_graphics_Paint_Align_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Paint.Align p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint.Align> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetYLabelsAlign (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setYLabelsAlign_Landroid_graphics_Paint_Align_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYMultipleSeriesRenderer']/method[@name='setYLabelsAlign' and count(parameter)=1 and parameter[1][@type='android.graphics.Paint.Align']]"
		[Register ("setYLabelsAlign", "(Landroid/graphics/Paint$Align;)V", "GetSetYLabelsAlign_Landroid_graphics_Paint_Align_Handler")]
		public virtual void SetYLabelsAlign (global::Android.Graphics.Paint.Align p0)
		{
			if (id_setYLabelsAlign_Landroid_graphics_Paint_Align_ == IntPtr.Zero)
				id_setYLabelsAlign_Landroid_graphics_Paint_Align_ = JNIEnv.GetMethodID (class_ref, "setYLabelsAlign", "(Landroid/graphics/Paint$Align;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setYLabelsAlign_Landroid_graphics_Paint_Align_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setYLabelsAlign_Landroid_graphics_Paint_Align_, new JValue (p0));
		}

		static Delegate cb_setYLabelsAlign_Landroid_graphics_Paint_Align_I;
#pragma warning disable 0169
		static Delegate GetSetYLabelsAlign_Landroid_graphics_Paint_Align_IHandler ()
		{
			if (cb_setYLabelsAlign_Landroid_graphics_Paint_Align_I == null)
				cb_setYLabelsAlign_Landroid_graphics_Paint_Align_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_SetYLabelsAlign_Landroid_graphics_Paint_Align_I);
			return cb_setYLabelsAlign_Landroid_graphics_Paint_Align_I;
		}

		static void n_SetYLabelsAlign_Landroid_graphics_Paint_Align_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Paint.Align p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint.Align> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetYLabelsAlign (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setYLabelsAlign_Landroid_graphics_Paint_Align_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYMultipleSeriesRenderer']/method[@name='setYLabelsAlign' and count(parameter)=2 and parameter[1][@type='android.graphics.Paint.Align'] and parameter[2][@type='int']]"
		[Register ("setYLabelsAlign", "(Landroid/graphics/Paint$Align;I)V", "GetSetYLabelsAlign_Landroid_graphics_Paint_Align_IHandler")]
		public virtual void SetYLabelsAlign (global::Android.Graphics.Paint.Align p0, int p1)
		{
			if (id_setYLabelsAlign_Landroid_graphics_Paint_Align_I == IntPtr.Zero)
				id_setYLabelsAlign_Landroid_graphics_Paint_Align_I = JNIEnv.GetMethodID (class_ref, "setYLabelsAlign", "(Landroid/graphics/Paint$Align;I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setYLabelsAlign_Landroid_graphics_Paint_Align_I, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setYLabelsAlign_Landroid_graphics_Paint_Align_I, new JValue (p0), new JValue (p1));
		}

		static Delegate cb_setYLabelsColor_II;
#pragma warning disable 0169
		static Delegate GetSetYLabelsColor_IIHandler ()
		{
			if (cb_setYLabelsColor_II == null)
				cb_setYLabelsColor_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_SetYLabelsColor_II);
			return cb_setYLabelsColor_II;
		}

		static void n_SetYLabelsColor_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetYLabelsColor (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setYLabelsColor_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYMultipleSeriesRenderer']/method[@name='setYLabelsColor' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("setYLabelsColor", "(II)V", "GetSetYLabelsColor_IIHandler")]
		public virtual void SetYLabelsColor (int p0, int p1)
		{
			if (id_setYLabelsColor_II == IntPtr.Zero)
				id_setYLabelsColor_II = JNIEnv.GetMethodID (class_ref, "setYLabelsColor", "(II)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setYLabelsColor_II, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setYLabelsColor_II, new JValue (p0), new JValue (p1));
		}

		static Delegate cb_setYTitle_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetSetYTitle_Ljava_lang_String_IHandler ()
		{
			if (cb_setYTitle_Ljava_lang_String_I == null)
				cb_setYTitle_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_SetYTitle_Ljava_lang_String_I);
			return cb_setYTitle_Ljava_lang_String_I;
		}

		static void n_SetYTitle_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetYTitle (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setYTitle_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYMultipleSeriesRenderer']/method[@name='setYTitle' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("setYTitle", "(Ljava/lang/String;I)V", "GetSetYTitle_Ljava_lang_String_IHandler")]
		public virtual void SetYTitle (string p0, int p1)
		{
			if (id_setYTitle_Ljava_lang_String_I == IntPtr.Zero)
				id_setYTitle_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "setYTitle", "(Ljava/lang/String;I)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setYTitle_Ljava_lang_String_I, new JValue (native_p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setYTitle_Ljava_lang_String_I, new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_setZoomEnabled_ZZ;
#pragma warning disable 0169
		static Delegate GetSetZoomEnabled_ZZHandler ()
		{
			if (cb_setZoomEnabled_ZZ == null)
				cb_setZoomEnabled_ZZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool, bool>) n_SetZoomEnabled_ZZ);
			return cb_setZoomEnabled_ZZ;
		}

		static void n_SetZoomEnabled_ZZ (IntPtr jnienv, IntPtr native__this, bool p0, bool p1)
		{
			global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetZoomEnabled (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setZoomEnabled_ZZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYMultipleSeriesRenderer']/method[@name='setZoomEnabled' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='boolean']]"
		[Register ("setZoomEnabled", "(ZZ)V", "GetSetZoomEnabled_ZZHandler")]
		public virtual void SetZoomEnabled (bool p0, bool p1)
		{
			if (id_setZoomEnabled_ZZ == IntPtr.Zero)
				id_setZoomEnabled_ZZ = JNIEnv.GetMethodID (class_ref, "setZoomEnabled", "(ZZ)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setZoomEnabled_ZZ, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setZoomEnabled_ZZ, new JValue (p0), new JValue (p1));
		}

		static Delegate cb_setZoomLimits_arrayD;
#pragma warning disable 0169
		static Delegate GetSetZoomLimits_arrayDHandler ()
		{
			if (cb_setZoomLimits_arrayD == null)
				cb_setZoomLimits_arrayD = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetZoomLimits_arrayD);
			return cb_setZoomLimits_arrayD;
		}

		static void n_SetZoomLimits_arrayD (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			double[] p0 = (double[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (double));
			__this.SetZoomLimits (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_setZoomLimits_arrayD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYMultipleSeriesRenderer']/method[@name='setZoomLimits' and count(parameter)=1 and parameter[1][@type='double[]']]"
		[Register ("setZoomLimits", "([D)V", "GetSetZoomLimits_arrayDHandler")]
		public virtual void SetZoomLimits (double[] p0)
		{
			if (id_setZoomLimits_arrayD == IntPtr.Zero)
				id_setZoomLimits_arrayD = JNIEnv.GetMethodID (class_ref, "setZoomLimits", "([D)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setZoomLimits_arrayD, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setZoomLimits_arrayD, new JValue (native_p0));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
