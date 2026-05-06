using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreInstanceConfiguration
{
    [JsiiInterface(nativeType: typeof(ICoreInstanceConfigurationInstanceDetailsLaunchDetailsSourceDetailsInstanceSourceImageFilterDetails), fullyQualifiedName: "oci.coreInstanceConfiguration.CoreInstanceConfigurationInstanceDetailsLaunchDetailsSourceDetailsInstanceSourceImageFilterDetails")]
    public interface ICoreInstanceConfigurationInstanceDetailsLaunchDetailsSourceDetailsInstanceSourceImageFilterDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance_configuration#compartment_id CoreInstanceConfiguration#compartment_id}.</summary>
        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CompartmentId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance_configuration#defined_tags_filter CoreInstanceConfiguration#defined_tags_filter}.</summary>
        [JsiiProperty(name: "definedTagsFilter", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? DefinedTagsFilter
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance_configuration#operating_system CoreInstanceConfiguration#operating_system}.</summary>
        [JsiiProperty(name: "operatingSystem", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OperatingSystem
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance_configuration#operating_system_version CoreInstanceConfiguration#operating_system_version}.</summary>
        [JsiiProperty(name: "operatingSystemVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OperatingSystemVersion
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICoreInstanceConfigurationInstanceDetailsLaunchDetailsSourceDetailsInstanceSourceImageFilterDetails), fullyQualifiedName: "oci.coreInstanceConfiguration.CoreInstanceConfigurationInstanceDetailsLaunchDetailsSourceDetailsInstanceSourceImageFilterDetails")]
        internal sealed class _Proxy : DeputyBase, oci.CoreInstanceConfiguration.ICoreInstanceConfigurationInstanceDetailsLaunchDetailsSourceDetailsInstanceSourceImageFilterDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance_configuration#compartment_id CoreInstanceConfiguration#compartment_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CompartmentId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance_configuration#defined_tags_filter CoreInstanceConfiguration#defined_tags_filter}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "definedTagsFilter", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? DefinedTagsFilter
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance_configuration#operating_system CoreInstanceConfiguration#operating_system}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "operatingSystem", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OperatingSystem
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance_configuration#operating_system_version CoreInstanceConfiguration#operating_system_version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "operatingSystemVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OperatingSystemVersion
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
