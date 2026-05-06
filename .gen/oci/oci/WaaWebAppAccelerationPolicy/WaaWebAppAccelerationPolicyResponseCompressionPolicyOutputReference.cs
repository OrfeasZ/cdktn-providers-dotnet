using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.WaaWebAppAccelerationPolicy
{
    [JsiiClass(nativeType: typeof(oci.WaaWebAppAccelerationPolicy.WaaWebAppAccelerationPolicyResponseCompressionPolicyOutputReference), fullyQualifiedName: "oci.waaWebAppAccelerationPolicy.WaaWebAppAccelerationPolicyResponseCompressionPolicyOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class WaaWebAppAccelerationPolicyResponseCompressionPolicyOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public WaaWebAppAccelerationPolicyResponseCompressionPolicyOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected WaaWebAppAccelerationPolicyResponseCompressionPolicyOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected WaaWebAppAccelerationPolicyResponseCompressionPolicyOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putGzipCompression", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.waaWebAppAccelerationPolicy.WaaWebAppAccelerationPolicyResponseCompressionPolicyGzipCompression\"}}]")]
        public virtual void PutGzipCompression(oci.WaaWebAppAccelerationPolicy.IWaaWebAppAccelerationPolicyResponseCompressionPolicyGzipCompression @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.WaaWebAppAccelerationPolicy.IWaaWebAppAccelerationPolicyResponseCompressionPolicyGzipCompression)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetGzipCompression")]
        public virtual void ResetGzipCompression()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "gzipCompression", typeJson: "{\"fqn\":\"oci.waaWebAppAccelerationPolicy.WaaWebAppAccelerationPolicyResponseCompressionPolicyGzipCompressionOutputReference\"}")]
        public virtual oci.WaaWebAppAccelerationPolicy.WaaWebAppAccelerationPolicyResponseCompressionPolicyGzipCompressionOutputReference GzipCompression
        {
            get => GetInstanceProperty<oci.WaaWebAppAccelerationPolicy.WaaWebAppAccelerationPolicyResponseCompressionPolicyGzipCompressionOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "gzipCompressionInput", typeJson: "{\"fqn\":\"oci.waaWebAppAccelerationPolicy.WaaWebAppAccelerationPolicyResponseCompressionPolicyGzipCompression\"}", isOptional: true)]
        public virtual oci.WaaWebAppAccelerationPolicy.IWaaWebAppAccelerationPolicyResponseCompressionPolicyGzipCompression? GzipCompressionInput
        {
            get => GetInstanceProperty<oci.WaaWebAppAccelerationPolicy.IWaaWebAppAccelerationPolicyResponseCompressionPolicyGzipCompression?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.waaWebAppAccelerationPolicy.WaaWebAppAccelerationPolicyResponseCompressionPolicy\"}", isOptional: true)]
        public virtual oci.WaaWebAppAccelerationPolicy.IWaaWebAppAccelerationPolicyResponseCompressionPolicy? InternalValue
        {
            get => GetInstanceProperty<oci.WaaWebAppAccelerationPolicy.IWaaWebAppAccelerationPolicyResponseCompressionPolicy?>();
            set => SetInstanceProperty(value);
        }
    }
}
