using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Achartengine.Renderer {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYSeriesRenderer']"
	[global::Android.Runtime.Register ("org/achartengine/renderer/XYSeriesRenderer", DoNotGenerateAcw=true)]
	public partial class XYSeriesRenderer : global::Org.Achartengine.Renderer.SimpleSeriesRenderer {

		// Metadata.xml XPath class reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYSeriesRenderer.FillOutsideLine.Type']"
		[global::Android.Runtime.Register ("org/achartengine/renderer/XYSeriesRenderer$FillOutsideLine$Type", DoNotGenerateAcw=true)]
		public sealed partial class Type : global::Java.Lang.Enum {


			static IntPtr ABOVE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYSeriesRenderer.FillOutsideLine.Type']/field[@name='ABOVE']"
			[Register ("ABOVE")]
			public static global::Org.Achartengine.Renderer.XYSeriesRenderer.Type Above {
				get {
					if (ABOVE_jfieldId == IntPtr.Zero)
						ABOVE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ABOVE", "Lorg/achartengine/renderer/XYSeriesRenderer$FillOutsideLine$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ABOVE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYSeriesRenderer.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (ABOVE_jfieldId == IntPtr.Zero)
						ABOVE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ABOVE", "Lorg/achartengine/renderer/XYSeriesRenderer$FillOutsideLine$Type;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, ABOVE_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr BELOW_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYSeriesRenderer.FillOutsideLine.Type']/field[@name='BELOW']"
			[Register ("BELOW")]
			public static global::Org.Achartengine.Renderer.XYSeriesRenderer.Type Below {
				get {
					if (BELOW_jfieldId == IntPtr.Zero)
						BELOW_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BELOW", "Lorg/achartengine/renderer/XYSeriesRenderer$FillOutsideLine$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BELOW_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYSeriesRenderer.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (BELOW_jfieldId == IntPtr.Zero)
						BELOW_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BELOW", "Lorg/achartengine/renderer/XYSeriesRenderer$FillOutsideLine$Type;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, BELOW_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr BOUNDS_ABOVE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYSeriesRenderer.FillOutsideLine.Type']/field[@name='BOUNDS_ABOVE']"
			[Register ("BOUNDS_ABOVE")]
			public static global::Org.Achartengine.Renderer.XYSeriesRenderer.Type BoundsAbove {
				get {
					if (BOUNDS_ABOVE_jfieldId == IntPtr.Zero)
						BOUNDS_ABOVE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BOUNDS_ABOVE", "Lorg/achartengine/renderer/XYSeriesRenderer$FillOutsideLine$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BOUNDS_ABOVE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYSeriesRenderer.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (BOUNDS_ABOVE_jfieldId == IntPtr.Zero)
						BOUNDS_ABOVE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BOUNDS_ABOVE", "Lorg/achartengine/renderer/XYSeriesRenderer$FillOutsideLine$Type;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, BOUNDS_ABOVE_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr BOUNDS_ALL_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYSeriesRenderer.FillOutsideLine.Type']/field[@name='BOUNDS_ALL']"
			[Register ("BOUNDS_ALL")]
			public static global::Org.Achartengine.Renderer.XYSeriesRenderer.Type BoundsAll {
				get {
					if (BOUNDS_ALL_jfieldId == IntPtr.Zero)
						BOUNDS_ALL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BOUNDS_ALL", "Lorg/achartengine/renderer/XYSeriesRenderer$FillOutsideLine$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BOUNDS_ALL_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYSeriesRenderer.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (BOUNDS_ALL_jfieldId == IntPtr.Zero)
						BOUNDS_ALL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BOUNDS_ALL", "Lorg/achartengine/renderer/XYSeriesRenderer$FillOutsideLine$Type;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, BOUNDS_ALL_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr BOUNDS_BELOW_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYSeriesRenderer.FillOutsideLine.Type']/field[@name='BOUNDS_BELOW']"
			[Register ("BOUNDS_BELOW")]
			public static global::Org.Achartengine.Renderer.XYSeriesRenderer.Type BoundsBelow {
				get {
					if (BOUNDS_BELOW_jfieldId == IntPtr.Zero)
						BOUNDS_BELOW_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BOUNDS_BELOW", "Lorg/achartengine/renderer/XYSeriesRenderer$FillOutsideLine$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BOUNDS_BELOW_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYSeriesRenderer.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (BOUNDS_BELOW_jfieldId == IntPtr.Zero)
						BOUNDS_BELOW_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BOUNDS_BELOW", "Lorg/achartengine/renderer/XYSeriesRenderer$FillOutsideLine$Type;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, BOUNDS_BELOW_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr NONE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYSeriesRenderer.FillOutsideLine.Type']/field[@name='NONE']"
			[Register ("NONE")]
			public static global::Org.Achartengine.Renderer.XYSeriesRenderer.Type None {
				get {
					if (NONE_jfieldId == IntPtr.Zero)
						NONE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NONE", "Lorg/achartengine/renderer/XYSeriesRenderer$FillOutsideLine$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NONE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYSeriesRenderer.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (NONE_jfieldId == IntPtr.Zero)
						NONE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NONE", "Lorg/achartengine/renderer/XYSeriesRenderer$FillOutsideLine$Type;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, NONE_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/achartengine/renderer/XYSeriesRenderer$FillOutsideLine$Type", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Type); }
			}

			internal Type (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYSeriesRenderer.FillOutsideLine.Type']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lorg/achartengine/renderer/XYSeriesRenderer$FillOutsideLine$Type;", "")]
			public static global::Org.Achartengine.Renderer.XYSeriesRenderer.Type ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lorg/achartengine/renderer/XYSeriesRenderer$FillOutsideLine$Type;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				global::Org.Achartengine.Renderer.XYSeriesRenderer.Type __ret = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYSeriesRenderer.Type> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYSeriesRenderer.FillOutsideLine.Type']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lorg/achartengine/renderer/XYSeriesRenderer$FillOutsideLine$Type;", "")]
			public static global::Org.Achartengine.Renderer.XYSeriesRenderer.Type[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lorg/achartengine/renderer/XYSeriesRenderer$FillOutsideLine$Type;");
				return (global::Org.Achartengine.Renderer.XYSeriesRenderer.Type[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Achartengine.Renderer.XYSeriesRenderer.Type));
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/achartengine/renderer/XYSeriesRenderer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (XYSeriesRenderer); }
		}

		protected XYSeriesRenderer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYSeriesRenderer']/constructor[@name='XYSeriesRenderer' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public XYSeriesRenderer () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (XYSeriesRenderer)) {
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

		static Delegate cb_isFillBelowLine;
#pragma warning disable 0169
		static Delegate GetIsFillBelowLineHandler ()
		{
			if (cb_isFillBelowLine == null)
				cb_isFillBelowLine = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsFillBelowLine);
			return cb_isFillBelowLine;
		}

		static bool n_IsFillBelowLine (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Renderer.XYSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FillBelowLine;
		}
#pragma warning restore 0169

		static Delegate cb_setFillBelowLine_Z;
#pragma warning disable 0169
		static Delegate GetSetFillBelowLine_ZHandler ()
		{
			if (cb_setFillBelowLine_Z == null)
				cb_setFillBelowLine_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetFillBelowLine_Z);
			return cb_setFillBelowLine_Z;
		}

		static void n_SetFillBelowLine_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Org.Achartengine.Renderer.XYSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.FillBelowLine = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isFillBelowLine;
		static IntPtr id_setFillBelowLine_Z;
		[Obsolete (@"deprecated")]
		public virtual bool FillBelowLine {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYSeriesRenderer']/method[@name='isFillBelowLine' and count(parameter)=0]"
			[Register ("isFillBelowLine", "()Z", "GetIsFillBelowLineHandler")]
			get {
				if (id_isFillBelowLine == IntPtr.Zero)
					id_isFillBelowLine = JNIEnv.GetMethodID (class_ref, "isFillBelowLine", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isFillBelowLine);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_isFillBelowLine);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYSeriesRenderer']/method[@name='setFillBelowLine' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setFillBelowLine", "(Z)V", "GetSetFillBelowLine_ZHandler")]
			set {
				if (id_setFillBelowLine_Z == IntPtr.Zero)
					id_setFillBelowLine_Z = JNIEnv.GetMethodID (class_ref, "setFillBelowLine", "(Z)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setFillBelowLine_Z, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setFillBelowLine_Z, new JValue (value));
			}
		}

		static Delegate cb_isFillPoints;
#pragma warning disable 0169
		static Delegate GetIsFillPointsHandler ()
		{
			if (cb_isFillPoints == null)
				cb_isFillPoints = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsFillPoints);
			return cb_isFillPoints;
		}

		static bool n_IsFillPoints (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Renderer.XYSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FillPoints;
		}
#pragma warning restore 0169

		static Delegate cb_setFillPoints_Z;
#pragma warning disable 0169
		static Delegate GetSetFillPoints_ZHandler ()
		{
			if (cb_setFillPoints_Z == null)
				cb_setFillPoints_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetFillPoints_Z);
			return cb_setFillPoints_Z;
		}

		static void n_SetFillPoints_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Org.Achartengine.Renderer.XYSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.FillPoints = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isFillPoints;
		static IntPtr id_setFillPoints_Z;
		public virtual bool FillPoints {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYSeriesRenderer']/method[@name='isFillPoints' and count(parameter)=0]"
			[Register ("isFillPoints", "()Z", "GetIsFillPointsHandler")]
			get {
				if (id_isFillPoints == IntPtr.Zero)
					id_isFillPoints = JNIEnv.GetMethodID (class_ref, "isFillPoints", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isFillPoints);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_isFillPoints);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYSeriesRenderer']/method[@name='setFillPoints' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setFillPoints", "(Z)V", "GetSetFillPoints_ZHandler")]
			set {
				if (id_setFillPoints_Z == IntPtr.Zero)
					id_setFillPoints_Z = JNIEnv.GetMethodID (class_ref, "setFillPoints", "(Z)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setFillPoints_Z, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setFillPoints_Z, new JValue (value));
			}
		}

		static Delegate cb_getLineWidth;
#pragma warning disable 0169
		static Delegate GetGetLineWidthHandler ()
		{
			if (cb_getLineWidth == null)
				cb_getLineWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetLineWidth);
			return cb_getLineWidth;
		}

		static float n_GetLineWidth (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Renderer.XYSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LineWidth;
		}
#pragma warning restore 0169

		static Delegate cb_setLineWidth_F;
#pragma warning disable 0169
		static Delegate GetSetLineWidth_FHandler ()
		{
			if (cb_setLineWidth_F == null)
				cb_setLineWidth_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetLineWidth_F);
			return cb_setLineWidth_F;
		}

		static void n_SetLineWidth_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Org.Achartengine.Renderer.XYSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.LineWidth = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getLineWidth;
		static IntPtr id_setLineWidth_F;
		public virtual float LineWidth {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYSeriesRenderer']/method[@name='getLineWidth' and count(parameter)=0]"
			[Register ("getLineWidth", "()F", "GetGetLineWidthHandler")]
			get {
				if (id_getLineWidth == IntPtr.Zero)
					id_getLineWidth = JNIEnv.GetMethodID (class_ref, "getLineWidth", "()F");

				if (GetType () == ThresholdType)
					return JNIEnv.CallFloatMethod  (Handle, id_getLineWidth);
				else
					return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, id_getLineWidth);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYSeriesRenderer']/method[@name='setLineWidth' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setLineWidth", "(F)V", "GetSetLineWidth_FHandler")]
			set {
				if (id_setLineWidth_F == IntPtr.Zero)
					id_setLineWidth_F = JNIEnv.GetMethodID (class_ref, "setLineWidth", "(F)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setLineWidth_F, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setLineWidth_F, new JValue (value));
			}
		}

		static Delegate cb_getPointStrokeWidth;
#pragma warning disable 0169
		static Delegate GetGetPointStrokeWidthHandler ()
		{
			if (cb_getPointStrokeWidth == null)
				cb_getPointStrokeWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetPointStrokeWidth);
			return cb_getPointStrokeWidth;
		}

		static float n_GetPointStrokeWidth (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Renderer.XYSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PointStrokeWidth;
		}
#pragma warning restore 0169

		static Delegate cb_setPointStrokeWidth_F;
#pragma warning disable 0169
		static Delegate GetSetPointStrokeWidth_FHandler ()
		{
			if (cb_setPointStrokeWidth_F == null)
				cb_setPointStrokeWidth_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetPointStrokeWidth_F);
			return cb_setPointStrokeWidth_F;
		}

		static void n_SetPointStrokeWidth_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Org.Achartengine.Renderer.XYSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PointStrokeWidth = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getPointStrokeWidth;
		static IntPtr id_setPointStrokeWidth_F;
		public virtual float PointStrokeWidth {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYSeriesRenderer']/method[@name='getPointStrokeWidth' and count(parameter)=0]"
			[Register ("getPointStrokeWidth", "()F", "GetGetPointStrokeWidthHandler")]
			get {
				if (id_getPointStrokeWidth == IntPtr.Zero)
					id_getPointStrokeWidth = JNIEnv.GetMethodID (class_ref, "getPointStrokeWidth", "()F");

				if (GetType () == ThresholdType)
					return JNIEnv.CallFloatMethod  (Handle, id_getPointStrokeWidth);
				else
					return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, id_getPointStrokeWidth);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYSeriesRenderer']/method[@name='setPointStrokeWidth' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setPointStrokeWidth", "(F)V", "GetSetPointStrokeWidth_FHandler")]
			set {
				if (id_setPointStrokeWidth_F == IntPtr.Zero)
					id_setPointStrokeWidth_F = JNIEnv.GetMethodID (class_ref, "setPointStrokeWidth", "(F)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setPointStrokeWidth_F, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setPointStrokeWidth_F, new JValue (value));
			}
		}

		static Delegate cb_getPointStyle;
#pragma warning disable 0169
		static Delegate GetGetPointStyleHandler ()
		{
			if (cb_getPointStyle == null)
				cb_getPointStyle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPointStyle);
			return cb_getPointStyle;
		}

		static IntPtr n_GetPointStyle (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Renderer.XYSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PointStyle);
		}
#pragma warning restore 0169

		static Delegate cb_setPointStyle_Lorg_achartengine_chart_PointStyle_;
#pragma warning disable 0169
		static Delegate GetSetPointStyle_Lorg_achartengine_chart_PointStyle_Handler ()
		{
			if (cb_setPointStyle_Lorg_achartengine_chart_PointStyle_ == null)
				cb_setPointStyle_Lorg_achartengine_chart_PointStyle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPointStyle_Lorg_achartengine_chart_PointStyle_);
			return cb_setPointStyle_Lorg_achartengine_chart_PointStyle_;
		}

		static void n_SetPointStyle_Lorg_achartengine_chart_PointStyle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Achartengine.Renderer.XYSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Achartengine.Chart.PointStyle p0 = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Chart.PointStyle> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PointStyle = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getPointStyle;
		static IntPtr id_setPointStyle_Lorg_achartengine_chart_PointStyle_;
		public virtual global::Org.Achartengine.Chart.PointStyle PointStyle {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYSeriesRenderer']/method[@name='getPointStyle' and count(parameter)=0]"
			[Register ("getPointStyle", "()Lorg/achartengine/chart/PointStyle;", "GetGetPointStyleHandler")]
			get {
				if (id_getPointStyle == IntPtr.Zero)
					id_getPointStyle = JNIEnv.GetMethodID (class_ref, "getPointStyle", "()Lorg/achartengine/chart/PointStyle;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Achartengine.Chart.PointStyle> (JNIEnv.CallObjectMethod  (Handle, id_getPointStyle), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Achartengine.Chart.PointStyle> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getPointStyle), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYSeriesRenderer']/method[@name='setPointStyle' and count(parameter)=1 and parameter[1][@type='org.achartengine.chart.PointStyle']]"
			[Register ("setPointStyle", "(Lorg/achartengine/chart/PointStyle;)V", "GetSetPointStyle_Lorg_achartengine_chart_PointStyle_Handler")]
			set {
				if (id_setPointStyle_Lorg_achartengine_chart_PointStyle_ == IntPtr.Zero)
					id_setPointStyle_Lorg_achartengine_chart_PointStyle_ = JNIEnv.GetMethodID (class_ref, "setPointStyle", "(Lorg/achartengine/chart/PointStyle;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setPointStyle_Lorg_achartengine_chart_PointStyle_, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setPointStyle_Lorg_achartengine_chart_PointStyle_, new JValue (value));
			}
		}

		static Delegate cb_setFillBelowLineColor_I;
#pragma warning disable 0169
		static Delegate GetSetFillBelowLineColor_IHandler ()
		{
			if (cb_setFillBelowLineColor_I == null)
				cb_setFillBelowLineColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetFillBelowLineColor_I);
			return cb_setFillBelowLineColor_I;
		}

		static void n_SetFillBelowLineColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Achartengine.Renderer.XYSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetFillBelowLineColor (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setFillBelowLineColor_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYSeriesRenderer']/method[@name='setFillBelowLineColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setFillBelowLineColor", "(I)V", "GetSetFillBelowLineColor_IHandler")]
		public virtual void SetFillBelowLineColor (int p0)
		{
			if (id_setFillBelowLineColor_I == IntPtr.Zero)
				id_setFillBelowLineColor_I = JNIEnv.GetMethodID (class_ref, "setFillBelowLineColor", "(I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setFillBelowLineColor_I, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setFillBelowLineColor_I, new JValue (p0));
		}

	}
}
