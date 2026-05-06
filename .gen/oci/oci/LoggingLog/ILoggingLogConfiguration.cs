using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.LoggingLog
{
    [JsiiInterface(nativeType: typeof(ILoggingLogConfiguration), fullyQualifiedName: "oci.loggingLog.LoggingLogConfiguration")]
    public interface ILoggingLogConfiguration
    {
        /// <summary>source block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/logging_log#source LoggingLog#source}
        /// </remarks>
        [JsiiProperty(name: "source", typeJson: "{\"fqn\":\"oci.loggingLog.LoggingLogConfigurationSource\"}")]
        oci.LoggingLog.ILoggingLogConfigurationSource Source
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/logging_log#compartment_id LoggingLog#compartment_id}.</summary>
        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CompartmentId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILoggingLogConfiguration), fullyQualifiedName: "oci.loggingLog.LoggingLogConfiguration")]
        internal sealed class _Proxy : DeputyBase, oci.LoggingLog.ILoggingLogConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>source block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/logging_log#source LoggingLog#source}
            /// </remarks>
            [JsiiProperty(name: "source", typeJson: "{\"fqn\":\"oci.loggingLog.LoggingLogConfigurationSource\"}")]
            public oci.LoggingLog.ILoggingLogConfigurationSource Source
            {
                get => GetInstanceProperty<oci.LoggingLog.ILoggingLogConfigurationSource>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/logging_log#compartment_id LoggingLog#compartment_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CompartmentId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
