using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azapi.DataAzapiDataPlaneResource
{
    [JsiiInterface(nativeType: typeof(IDataAzapiDataPlaneResourceConfig), fullyQualifiedName: "azapi.dataAzapiDataPlaneResource.DataAzapiDataPlaneResourceConfig")]
    public interface IDataAzapiDataPlaneResourceConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>The ID of the azure resource in which this resource exists.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/azure/azapi/2.13.0/docs/data-sources/data_plane_resource#parent_id DataAzapiDataPlaneResource#parent_id}
        /// </remarks>
        [JsiiProperty(name: "parentId", typeJson: "{\"primitive\":\"string\"}")]
        string ParentId
        {
            get;
        }

        /// <summary>In a format like `&lt;resource-type&gt;@&lt;api-version&gt;`.</summary>
        /// <remarks>
        /// <c>&lt;resource-type&gt;</c> is the Azure resource type, for example, <c>Microsoft.Storage/storageAccounts</c>. <c>&lt;api-version&gt;</c> is version of the API used to manage this azure resource. For a list of supported data plane resource types, see the <a href="https://registry.terraform.io/providers/Azure/azapi/latest/docs/resources/data_plane_resource#available-resources">Available Resources</a> documentation.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/azure/azapi/2.13.0/docs/data-sources/data_plane_resource#type DataAzapiDataPlaneResource#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Specifies the name (identifier segment) of the data plane resource.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/azure/azapi/2.13.0/docs/data-sources/data_plane_resource#name DataAzapiDataPlaneResource#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        /// <summary>The attribute can accept either a list or a map.</summary>
        /// <remarks>
        /// <list type="bullet">
        /// <description><strong>List</strong>: A list of paths that need to be exported from the response body. Setting it to <c>["*"]</c> will export the full response body. Here's an example. If it sets to <c>["properties.loginServer", "properties.policies.quarantinePolicy.status"]</c>, it will set the following HCL object to the computed property output.
        ///
        /// <code><![CDATA[
        /// {
        /// 	properties = {
        /// 		loginServer = "registry1.azurecr.io"
        /// 		policies = {
        /// 			quarantinePolicy = {
        /// 				status = "disabled"
        /// 			}
        /// 		}
        /// 	}
        /// }
        /// ]]></code></description>
        /// <description><strong>Map</strong>: A map where the key is the name for the result and the value is a JMESPath query string to filter the response. Here's an example. If it sets to <c>{"login_server": "properties.loginServer", "quarantine_status": "properties.policies.quarantinePolicy.status"}</c>, it will set the following HCL object to the computed property output.
        ///
        /// <code><![CDATA[
        /// {
        /// 	"login_server" = "registry1.azurecr.io"
        /// 	"quarantine_status" = "disabled"
        /// }
        /// ]]></code></description>
        /// </list>
        ///
        /// To learn more about JMESPath, visit <a href="https://jmespath.org/">JMESPath</a>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/azure/azapi/2.13.0/docs/data-sources/data_plane_resource#response_export_values DataAzapiDataPlaneResource#response_export_values}
        /// </remarks>
        [JsiiProperty(name: "responseExportValues", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, object>? ResponseExportValues
        {
            get
            {
                return null;
            }
        }

        /// <summary>The retry object supports the following attributes:.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/azure/azapi/2.13.0/docs/data-sources/data_plane_resource#retry DataAzapiDataPlaneResource#retry}
        /// </remarks>
        [JsiiProperty(name: "retry", typeJson: "{\"fqn\":\"azapi.dataAzapiDataPlaneResource.DataAzapiDataPlaneResourceRetry\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azapi.DataAzapiDataPlaneResource.IDataAzapiDataPlaneResourceRetry? Retry
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/azure/azapi/2.13.0/docs/data-sources/data_plane_resource#timeouts DataAzapiDataPlaneResource#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azapi.dataAzapiDataPlaneResource.DataAzapiDataPlaneResourceTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azapi.DataAzapiDataPlaneResource.IDataAzapiDataPlaneResourceTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzapiDataPlaneResourceConfig), fullyQualifiedName: "azapi.dataAzapiDataPlaneResource.DataAzapiDataPlaneResourceConfig")]
        internal sealed class _Proxy : DeputyBase, azapi.DataAzapiDataPlaneResource.IDataAzapiDataPlaneResourceConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The ID of the azure resource in which this resource exists.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/azure/azapi/2.13.0/docs/data-sources/data_plane_resource#parent_id DataAzapiDataPlaneResource#parent_id}
            /// </remarks>
            [JsiiProperty(name: "parentId", typeJson: "{\"primitive\":\"string\"}")]
            public string ParentId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>In a format like `&lt;resource-type&gt;@&lt;api-version&gt;`.</summary>
            /// <remarks>
            /// <c>&lt;resource-type&gt;</c> is the Azure resource type, for example, <c>Microsoft.Storage/storageAccounts</c>. <c>&lt;api-version&gt;</c> is version of the API used to manage this azure resource. For a list of supported data plane resource types, see the <a href="https://registry.terraform.io/providers/Azure/azapi/latest/docs/resources/data_plane_resource#available-resources">Available Resources</a> documentation.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/azure/azapi/2.13.0/docs/data-sources/data_plane_resource#type DataAzapiDataPlaneResource#type}
            /// </remarks>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Specifies the name (identifier segment) of the data plane resource.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/azure/azapi/2.13.0/docs/data-sources/data_plane_resource#name DataAzapiDataPlaneResource#name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The attribute can accept either a list or a map.</summary>
            /// <remarks>
            /// <list type="bullet">
            /// <description><strong>List</strong>: A list of paths that need to be exported from the response body. Setting it to <c>["*"]</c> will export the full response body. Here's an example. If it sets to <c>["properties.loginServer", "properties.policies.quarantinePolicy.status"]</c>, it will set the following HCL object to the computed property output.
            ///
            /// <code><![CDATA[
            /// {
            /// 	properties = {
            /// 		loginServer = "registry1.azurecr.io"
            /// 		policies = {
            /// 			quarantinePolicy = {
            /// 				status = "disabled"
            /// 			}
            /// 		}
            /// 	}
            /// }
            /// ]]></code></description>
            /// <description><strong>Map</strong>: A map where the key is the name for the result and the value is a JMESPath query string to filter the response. Here's an example. If it sets to <c>{"login_server": "properties.loginServer", "quarantine_status": "properties.policies.quarantinePolicy.status"}</c>, it will set the following HCL object to the computed property output.
            ///
            /// <code><![CDATA[
            /// {
            /// 	"login_server" = "registry1.azurecr.io"
            /// 	"quarantine_status" = "disabled"
            /// }
            /// ]]></code></description>
            /// </list>
            ///
            /// To learn more about JMESPath, visit <a href="https://jmespath.org/">JMESPath</a>.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/azure/azapi/2.13.0/docs/data-sources/data_plane_resource#response_export_values DataAzapiDataPlaneResource#response_export_values}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "responseExportValues", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, object>? ResponseExportValues
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, object>?>();
            }

            /// <summary>The retry object supports the following attributes:.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/azure/azapi/2.13.0/docs/data-sources/data_plane_resource#retry DataAzapiDataPlaneResource#retry}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "retry", typeJson: "{\"fqn\":\"azapi.dataAzapiDataPlaneResource.DataAzapiDataPlaneResourceRetry\"}", isOptional: true)]
            public azapi.DataAzapiDataPlaneResource.IDataAzapiDataPlaneResourceRetry? Retry
            {
                get => GetInstanceProperty<azapi.DataAzapiDataPlaneResource.IDataAzapiDataPlaneResourceRetry?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/azure/azapi/2.13.0/docs/data-sources/data_plane_resource#timeouts DataAzapiDataPlaneResource#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azapi.dataAzapiDataPlaneResource.DataAzapiDataPlaneResourceTimeouts\"}", isOptional: true)]
            public azapi.DataAzapiDataPlaneResource.IDataAzapiDataPlaneResourceTimeouts? Timeouts
            {
                get => GetInstanceProperty<azapi.DataAzapiDataPlaneResource.IDataAzapiDataPlaneResourceTimeouts?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: either <see cref="Io.Cdktn.ISSHProvisionerConnection" /> or <see cref="Io.Cdktn.IWinrmProvisionerConnection" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: either double or <see cref="Io.Cdktn.TerraformCount" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public Io.Cdktn.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
            public Io.Cdktn.ITerraformIterator? ForEach
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformIterator?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
            public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
            public Io.Cdktn.TerraformProvider? Provider
            {
                get => GetInstanceProperty<Io.Cdktn.TerraformProvider?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: (either <see cref="Io.Cdktn.IFileProvisioner" /> or <see cref="Io.Cdktn.ILocalExecProvisioner" /> or <see cref="Io.Cdktn.IRemoteExecProvisioner" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
            public object[]? Provisioners
            {
                get => GetInstanceProperty<object[]?>();
            }
        }
    }
}
