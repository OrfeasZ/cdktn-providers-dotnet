using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.WaaWebAppAccelerationPolicy
{
    [JsiiInterface(nativeType: typeof(IWaaWebAppAccelerationPolicyResponseCompressionPolicy), fullyQualifiedName: "oci.waaWebAppAccelerationPolicy.WaaWebAppAccelerationPolicyResponseCompressionPolicy")]
    public interface IWaaWebAppAccelerationPolicyResponseCompressionPolicy
    {
        /// <summary>gzip_compression block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waa_web_app_acceleration_policy#gzip_compression WaaWebAppAccelerationPolicy#gzip_compression}
        /// </remarks>
        [JsiiProperty(name: "gzipCompression", typeJson: "{\"fqn\":\"oci.waaWebAppAccelerationPolicy.WaaWebAppAccelerationPolicyResponseCompressionPolicyGzipCompression\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.WaaWebAppAccelerationPolicy.IWaaWebAppAccelerationPolicyResponseCompressionPolicyGzipCompression? GzipCompression
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWaaWebAppAccelerationPolicyResponseCompressionPolicy), fullyQualifiedName: "oci.waaWebAppAccelerationPolicy.WaaWebAppAccelerationPolicyResponseCompressionPolicy")]
        internal sealed class _Proxy : DeputyBase, oci.WaaWebAppAccelerationPolicy.IWaaWebAppAccelerationPolicyResponseCompressionPolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>gzip_compression block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waa_web_app_acceleration_policy#gzip_compression WaaWebAppAccelerationPolicy#gzip_compression}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "gzipCompression", typeJson: "{\"fqn\":\"oci.waaWebAppAccelerationPolicy.WaaWebAppAccelerationPolicyResponseCompressionPolicyGzipCompression\"}", isOptional: true)]
            public oci.WaaWebAppAccelerationPolicy.IWaaWebAppAccelerationPolicyResponseCompressionPolicyGzipCompression? GzipCompression
            {
                get => GetInstanceProperty<oci.WaaWebAppAccelerationPolicy.IWaaWebAppAccelerationPolicyResponseCompressionPolicyGzipCompression?>();
            }
        }
    }
}
