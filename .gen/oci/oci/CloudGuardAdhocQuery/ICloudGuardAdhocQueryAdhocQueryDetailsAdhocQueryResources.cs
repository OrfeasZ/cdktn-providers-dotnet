using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CloudGuardAdhocQuery
{
    [JsiiInterface(nativeType: typeof(ICloudGuardAdhocQueryAdhocQueryDetailsAdhocQueryResources), fullyQualifiedName: "oci.cloudGuardAdhocQuery.CloudGuardAdhocQueryAdhocQueryDetailsAdhocQueryResources")]
    public interface ICloudGuardAdhocQueryAdhocQueryDetailsAdhocQueryResources
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_guard_adhoc_query#region CloudGuardAdhocQuery#region}.</summary>
        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Region
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_guard_adhoc_query#resource_ids CloudGuardAdhocQuery#resource_ids}.</summary>
        [JsiiProperty(name: "resourceIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? ResourceIds
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_guard_adhoc_query#resource_type CloudGuardAdhocQuery#resource_type}.</summary>
        [JsiiProperty(name: "resourceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ResourceType
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudGuardAdhocQueryAdhocQueryDetailsAdhocQueryResources), fullyQualifiedName: "oci.cloudGuardAdhocQuery.CloudGuardAdhocQueryAdhocQueryDetailsAdhocQueryResources")]
        internal sealed class _Proxy : DeputyBase, oci.CloudGuardAdhocQuery.ICloudGuardAdhocQueryAdhocQueryDetailsAdhocQueryResources
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_guard_adhoc_query#region CloudGuardAdhocQuery#region}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Region
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_guard_adhoc_query#resource_ids CloudGuardAdhocQuery#resource_ids}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "resourceIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? ResourceIds
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_guard_adhoc_query#resource_type CloudGuardAdhocQuery#resource_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "resourceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ResourceType
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
