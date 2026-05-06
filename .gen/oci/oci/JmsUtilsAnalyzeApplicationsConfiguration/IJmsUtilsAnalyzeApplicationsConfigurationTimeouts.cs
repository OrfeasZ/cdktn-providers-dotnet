using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.JmsUtilsAnalyzeApplicationsConfiguration
{
    [JsiiInterface(nativeType: typeof(IJmsUtilsAnalyzeApplicationsConfigurationTimeouts), fullyQualifiedName: "oci.jmsUtilsAnalyzeApplicationsConfiguration.JmsUtilsAnalyzeApplicationsConfigurationTimeouts")]
    public interface IJmsUtilsAnalyzeApplicationsConfigurationTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_utils_analyze_applications_configuration#create JmsUtilsAnalyzeApplicationsConfiguration#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_utils_analyze_applications_configuration#delete JmsUtilsAnalyzeApplicationsConfiguration#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_utils_analyze_applications_configuration#update JmsUtilsAnalyzeApplicationsConfiguration#update}.</summary>
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Update
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IJmsUtilsAnalyzeApplicationsConfigurationTimeouts), fullyQualifiedName: "oci.jmsUtilsAnalyzeApplicationsConfiguration.JmsUtilsAnalyzeApplicationsConfigurationTimeouts")]
        internal sealed class _Proxy : DeputyBase, oci.JmsUtilsAnalyzeApplicationsConfiguration.IJmsUtilsAnalyzeApplicationsConfigurationTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_utils_analyze_applications_configuration#create JmsUtilsAnalyzeApplicationsConfiguration#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_utils_analyze_applications_configuration#delete JmsUtilsAnalyzeApplicationsConfiguration#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_utils_analyze_applications_configuration#update JmsUtilsAnalyzeApplicationsConfiguration#update}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Update
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
