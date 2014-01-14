using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Achartengine.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.achartengine.util']/class[@name='IndexXYMap']"
	[global::Android.Runtime.Register ("org/achartengine/util/IndexXYMap", DoNotGenerateAcw=true)]
	public partial class IndexXYMap : global::Java.Util.TreeMap {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/achartengine/util/IndexXYMap", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IndexXYMap); }
		}

		protected IndexXYMap (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.achartengine.util']/class[@name='IndexXYMap']/constructor[@name='IndexXYMap' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public IndexXYMap () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (IndexXYMap)) {
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

		static Delegate cb_getMaxXDifference;
#pragma warning disable 0169
		static Delegate GetGetMaxXDifferenceHandler ()
		{
			if (cb_getMaxXDifference == null)
				cb_getMaxXDifference = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetMaxXDifference);
			return cb_getMaxXDifference;
		}

		static double n_GetMaxXDifference (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Util.IndexXYMap __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Util.IndexXYMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaxXDifference;
		}
#pragma warning restore 0169

		static IntPtr id_getMaxXDifference;
		public virtual double MaxXDifference {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.util']/class[@name='IndexXYMap']/method[@name='getMaxXDifference' and count(parameter)=0]"
			[Register ("getMaxXDifference", "()D", "GetGetMaxXDifferenceHandler")]
			get {
				if (id_getMaxXDifference == IntPtr.Zero)
					id_getMaxXDifference = JNIEnv.GetMethodID (class_ref, "getMaxXDifference", "()D");

				if (GetType () == ThresholdType)
					return JNIEnv.CallDoubleMethod  (Handle, id_getMaxXDifference);
				else
					return JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, id_getMaxXDifference);
			}
		}

		static Delegate cb_getByIndex_I;
#pragma warning disable 0169
		static Delegate GetGetByIndex_IHandler ()
		{
			if (cb_getByIndex_I == null)
				cb_getByIndex_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetByIndex_I);
			return cb_getByIndex_I;
		}

		static IntPtr n_GetByIndex_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Achartengine.Util.IndexXYMap __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Util.IndexXYMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetByIndex (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getByIndex_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.util']/class[@name='IndexXYMap']/method[@name='getByIndex' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getByIndex", "(I)Lorg/achartengine/util/XYEntry;", "GetGetByIndex_IHandler")]
		public virtual global::Org.Achartengine.Util.XYEntry GetByIndex (int p0)
		{
			if (id_getByIndex_I == IntPtr.Zero)
				id_getByIndex_I = JNIEnv.GetMethodID (class_ref, "getByIndex", "(I)Lorg/achartengine/util/XYEntry;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Org.Achartengine.Util.XYEntry> (JNIEnv.CallObjectMethod  (Handle, id_getByIndex_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Org.Achartengine.Util.XYEntry> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getByIndex_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_getIndexForKey_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetGetIndexForKey_Ljava_lang_Object_Handler ()
		{
			if (cb_getIndexForKey_Ljava_lang_Object_ == null)
				cb_getIndexForKey_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_GetIndexForKey_Ljava_lang_Object_);
			return cb_getIndexForKey_Ljava_lang_Object_;
		}

		static int n_GetIndexForKey_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Achartengine.Util.IndexXYMap __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Util.IndexXYMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetIndexForKey (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getIndexForKey_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.util']/class[@name='IndexXYMap']/method[@name='getIndexForKey' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("getIndexForKey", "(Ljava/lang/Object;)I", "GetGetIndexForKey_Ljava_lang_Object_Handler")]
		public virtual int GetIndexForKey (global::Java.Lang.Object p0)
		{
			if (id_getIndexForKey_Ljava_lang_Object_ == IntPtr.Zero)
				id_getIndexForKey_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "getIndexForKey", "(Ljava/lang/Object;)I");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);

			int __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallIntMethod  (Handle, id_getIndexForKey_Ljava_lang_Object_, new JValue (native_p0));
			else
				__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, id_getIndexForKey_Ljava_lang_Object_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getXByIndex_I;
#pragma warning disable 0169
		static Delegate GetGetXByIndex_IHandler ()
		{
			if (cb_getXByIndex_I == null)
				cb_getXByIndex_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetXByIndex_I);
			return cb_getXByIndex_I;
		}

		static IntPtr n_GetXByIndex_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Achartengine.Util.IndexXYMap __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Util.IndexXYMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetXByIndex (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getXByIndex_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.util']/class[@name='IndexXYMap']/method[@name='getXByIndex' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getXByIndex", "(I)Ljava/lang/Object;", "GetGetXByIndex_IHandler")]
		public virtual global::Java.Lang.Object GetXByIndex (int p0)
		{
			if (id_getXByIndex_I == IntPtr.Zero)
				id_getXByIndex_I = JNIEnv.GetMethodID (class_ref, "getXByIndex", "(I)Ljava/lang/Object;");

			if (GetType () == ThresholdType)
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_getXByIndex_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getXByIndex_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_getYByIndex_I;
#pragma warning disable 0169
		static Delegate GetGetYByIndex_IHandler ()
		{
			if (cb_getYByIndex_I == null)
				cb_getYByIndex_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetYByIndex_I);
			return cb_getYByIndex_I;
		}

		static IntPtr n_GetYByIndex_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Achartengine.Util.IndexXYMap __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Util.IndexXYMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetYByIndex (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getYByIndex_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.util']/class[@name='IndexXYMap']/method[@name='getYByIndex' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getYByIndex", "(I)Ljava/lang/Object;", "GetGetYByIndex_IHandler")]
		public virtual global::Java.Lang.Object GetYByIndex (int p0)
		{
			if (id_getYByIndex_I == IntPtr.Zero)
				id_getYByIndex_I = JNIEnv.GetMethodID (class_ref, "getYByIndex", "(I)Ljava/lang/Object;");

			if (GetType () == ThresholdType)
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_getYByIndex_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getYByIndex_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_put_ILjava_lang_Object_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetPut_ILjava_lang_Object_Ljava_lang_Object_Handler ()
		{
			if (cb_put_ILjava_lang_Object_Ljava_lang_Object_ == null)
				cb_put_ILjava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr>) n_Put_ILjava_lang_Object_Ljava_lang_Object_);
			return cb_put_ILjava_lang_Object_Ljava_lang_Object_;
		}

		static IntPtr n_Put_ILjava_lang_Object_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Org.Achartengine.Util.IndexXYMap __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Util.IndexXYMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Put (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_put_ILjava_lang_Object_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.util']/class[@name='IndexXYMap']/method[@name='put' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='java.lang.Object']]"
		[Register ("put", "(ILjava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", "GetPut_ILjava_lang_Object_Ljava_lang_Object_Handler")]
		public virtual global::Java.Lang.Object Put (int p0, global::Java.Lang.Object p1, global::Java.Lang.Object p2)
		{
			if (id_put_ILjava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
				id_put_ILjava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "put", "(ILjava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;");
			IntPtr native_p1 = JNIEnv.ToLocalJniHandle (p1);
			IntPtr native_p2 = JNIEnv.ToLocalJniHandle (p2);

			global::Java.Lang.Object __ret;
			if (GetType () == ThresholdType)
				__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_put_ILjava_lang_Object_Ljava_lang_Object_, new JValue (p0), new JValue (native_p1), new JValue (native_p2)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_put_ILjava_lang_Object_Ljava_lang_Object_, new JValue (p0), new JValue (native_p1), new JValue (native_p2)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			return __ret;
		}

		static Delegate cb_removeByIndex_I;
#pragma warning disable 0169
		static Delegate GetRemoveByIndex_IHandler ()
		{
			if (cb_removeByIndex_I == null)
				cb_removeByIndex_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_RemoveByIndex_I);
			return cb_removeByIndex_I;
		}

		static IntPtr n_RemoveByIndex_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Achartengine.Util.IndexXYMap __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Util.IndexXYMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RemoveByIndex (p0));
		}
#pragma warning restore 0169

		static IntPtr id_removeByIndex_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.util']/class[@name='IndexXYMap']/method[@name='removeByIndex' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("removeByIndex", "(I)Lorg/achartengine/util/XYEntry;", "GetRemoveByIndex_IHandler")]
		public virtual global::Org.Achartengine.Util.XYEntry RemoveByIndex (int p0)
		{
			if (id_removeByIndex_I == IntPtr.Zero)
				id_removeByIndex_I = JNIEnv.GetMethodID (class_ref, "removeByIndex", "(I)Lorg/achartengine/util/XYEntry;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Org.Achartengine.Util.XYEntry> (JNIEnv.CallObjectMethod  (Handle, id_removeByIndex_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Org.Achartengine.Util.XYEntry> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_removeByIndex_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

	}
}
