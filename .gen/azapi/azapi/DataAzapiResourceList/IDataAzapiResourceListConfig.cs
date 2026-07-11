using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azapi.DataAzapiResourceList
{
    [JsiiInterface(nativeType: typeof(IDataAzapiResourceListConfig), fullyQualifiedName: "azapi.dataAzapiResourceList.DataAzapiResourceListConfig")]
    public interface IDataAzapiResourceListConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>The ID of the azure resource in which this resource is created.</summary>
        /// <remarks>
        /// It supports different kinds of deployment scope for <strong>top level</strong> resources:
        ///
        /// <list type="bullet">
        /// <description>resource group scope: <c>parent_id</c> should be the ID of a resource group, it's recommended to manage a resource group by azurerm_resource_group.</description>
        /// <description>management group scope: <c>parent_id</c> should be the ID of a management group, it's recommended to manage a management group by azurerm_management_group.</description>
        /// <description>extension scope: <c>parent_id</c> should be the ID of the resource you're adding the extension to.</description>
        /// <description>subscription scope: <c>parent_id</c> should be like \x60/subscriptions/00000000-0000-0000-0000-000000000000\x60</description>
        /// <description>tenant scope: <c>parent_id</c> should be /</description>
        /// </list>
        ///
        /// For child level resources, the <c>parent_id</c> should be the ID of its parent resource, for example, subnet resource's <c>parent_id</c> is the ID of the vnet.
        ///
        /// For type <c>Microsoft.Resources/resourceGroups</c>, the <c>parent_id</c> could be omitted, it defaults to subscription ID specified in provider or the default subscription (You could check the default subscription by azure cli command: <c>az account show</c>).
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/azure/azapi/2.10.0/docs/data-sources/resource_list#parent_id DataAzapiResourceList#parent_id}
        /// </remarks>
        [JsiiProperty(name: "parentId", typeJson: "{\"primitive\":\"string\"}")]
        string ParentId
        {
            get;
        }

        /// <summary>In a format like `&lt;resource-type&gt;@&lt;api-version&gt;`.</summary>
        /// <remarks>
        /// <c>&lt;resource-type&gt;</c> is the Azure resource type, for example, <c>Microsoft.Storage/storageAccounts</c>. <c>&lt;api-version&gt;</c> is version of the API used to manage this azure resource.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/azure/azapi/2.10.0/docs/data-sources/resource_list#type DataAzapiResourceList#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>A map of headers to include in the request.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/azure/azapi/2.10.0/docs/data-sources/resource_list#headers DataAzapiResourceList#headers}
        /// </remarks>
        [JsiiProperty(name: "headers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Headers
        {
            get
            {
                return null;
            }
        }

        /// <summary>A map of query parameters to include in the request.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/azure/azapi/2.10.0/docs/data-sources/resource_list#query_parameters DataAzapiResourceList#query_parameters}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or Dictionary&lt;string, (string)[]&gt;</para>
        /// </remarks>
        [JsiiProperty(name: "queryParameters", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}},\"kind\":\"map\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? QueryParameters
        {
            get
            {
                return null;
            }
        }

        /// <summary>The attribute can accept either a list or a map.</summary>
        /// <remarks>
        /// <list type="bullet">
        /// <description><strong>List</strong>: A list of paths that need to be exported from the response body. Setting it to <c>["*"]</c> will export the full response body. Here's an example. If it sets to <c>["value"]</c>, it will set the following HCL object to the computed property output.
        ///
        /// <code><![CDATA[
        /// {
        ///   "value" = [
        /// 	{
        /// 	  "id" = "/subscriptions/000000/resourceGroups/demo-rg/providers/Microsoft.Automation/automationAccounts/example"
        /// 	  "location" = "eastus2"
        /// 	  "name" = "example"
        /// 	  "properties" = {
        /// 		"creationTime" = "2024-10-11T08:18:38.737+00:00"
        /// 		"disableLocalAuth" = false
        /// 		"lastModifiedTime" = "2024-10-11T08:18:38.737+00:00"
        /// 		"publicNetworkAccess" = true
        /// 	  }
        /// 	  "tags" = {}
        /// 	  "type" = "Microsoft.Automation/AutomationAccounts"
        /// 	}
        ///   ]
        /// }
        /// ]]></code></description>
        /// <description><strong>Map</strong>: A map where the key is the name for the result and the value is a JMESPath query string to filter the response. Here's an example. If it sets to <c>{"values": "value[].{name: name, publicNetworkAccess: properties.publicNetworkAccess}", "names": "value[].name"}</c>, it will set the following HCL object to the computed property output.
        ///
        /// <code><![CDATA[
        /// {
        /// 	"names" = [
        /// 		"example",
        /// 		"fredaccount01",
        /// 	]
        /// 	"values" = [
        /// 		{
        /// 		  "name" = "example"
        /// 		  "publicNetworkAccess" = true
        /// 		},
        /// 		{
        /// 		  "name" = "fredaccount01"
        /// 		  "publicNetworkAccess" = null
        /// 		},
        /// 	]
        /// }
        /// ]]></code></description>
        /// </list>
        ///
        /// To learn more about JMESPath, visit <a href="https://jmespath.org/">JMESPath</a>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/azure/azapi/2.10.0/docs/data-sources/resource_list#response_export_values DataAzapiResourceList#response_export_values}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/azure/azapi/2.10.0/docs/data-sources/resource_list#retry DataAzapiResourceList#retry}
        /// </remarks>
        [JsiiProperty(name: "retry", typeJson: "{\"fqn\":\"azapi.dataAzapiResourceList.DataAzapiResourceListRetry\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azapi.DataAzapiResourceList.IDataAzapiResourceListRetry? Retry
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/azure/azapi/2.10.0/docs/data-sources/resource_list#timeouts DataAzapiResourceList#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azapi.dataAzapiResourceList.DataAzapiResourceListTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azapi.DataAzapiResourceList.IDataAzapiResourceListTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzapiResourceListConfig), fullyQualifiedName: "azapi.dataAzapiResourceList.DataAzapiResourceListConfig")]
        internal sealed class _Proxy : DeputyBase, azapi.DataAzapiResourceList.IDataAzapiResourceListConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The ID of the azure resource in which this resource is created.</summary>
            /// <remarks>
            /// It supports different kinds of deployment scope for <strong>top level</strong> resources:
            ///
            /// <list type="bullet">
            /// <description>resource group scope: <c>parent_id</c> should be the ID of a resource group, it's recommended to manage a resource group by azurerm_resource_group.</description>
            /// <description>management group scope: <c>parent_id</c> should be the ID of a management group, it's recommended to manage a management group by azurerm_management_group.</description>
            /// <description>extension scope: <c>parent_id</c> should be the ID of the resource you're adding the extension to.</description>
            /// <description>subscription scope: <c>parent_id</c> should be like \x60/subscriptions/00000000-0000-0000-0000-000000000000\x60</description>
            /// <description>tenant scope: <c>parent_id</c> should be /</description>
            /// </list>
            ///
            /// For child level resources, the <c>parent_id</c> should be the ID of its parent resource, for example, subnet resource's <c>parent_id</c> is the ID of the vnet.
            ///
            /// For type <c>Microsoft.Resources/resourceGroups</c>, the <c>parent_id</c> could be omitted, it defaults to subscription ID specified in provider or the default subscription (You could check the default subscription by azure cli command: <c>az account show</c>).
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/azure/azapi/2.10.0/docs/data-sources/resource_list#parent_id DataAzapiResourceList#parent_id}
            /// </remarks>
            [JsiiProperty(name: "parentId", typeJson: "{\"primitive\":\"string\"}")]
            public string ParentId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>In a format like `&lt;resource-type&gt;@&lt;api-version&gt;`.</summary>
            /// <remarks>
            /// <c>&lt;resource-type&gt;</c> is the Azure resource type, for example, <c>Microsoft.Storage/storageAccounts</c>. <c>&lt;api-version&gt;</c> is version of the API used to manage this azure resource.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/azure/azapi/2.10.0/docs/data-sources/resource_list#type DataAzapiResourceList#type}
            /// </remarks>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>A map of headers to include in the request.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/azure/azapi/2.10.0/docs/data-sources/resource_list#headers DataAzapiResourceList#headers}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "headers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Headers
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>A map of query parameters to include in the request.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/azure/azapi/2.10.0/docs/data-sources/resource_list#query_parameters DataAzapiResourceList#query_parameters}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or Dictionary&lt;string, (string)[]&gt;</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "queryParameters", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}},\"kind\":\"map\"}}]}}", isOptional: true)]
            public object? QueryParameters
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The attribute can accept either a list or a map.</summary>
            /// <remarks>
            /// <list type="bullet">
            /// <description><strong>List</strong>: A list of paths that need to be exported from the response body. Setting it to <c>["*"]</c> will export the full response body. Here's an example. If it sets to <c>["value"]</c>, it will set the following HCL object to the computed property output.
            ///
            /// <code><![CDATA[
            /// {
            ///   "value" = [
            /// 	{
            /// 	  "id" = "/subscriptions/000000/resourceGroups/demo-rg/providers/Microsoft.Automation/automationAccounts/example"
            /// 	  "location" = "eastus2"
            /// 	  "name" = "example"
            /// 	  "properties" = {
            /// 		"creationTime" = "2024-10-11T08:18:38.737+00:00"
            /// 		"disableLocalAuth" = false
            /// 		"lastModifiedTime" = "2024-10-11T08:18:38.737+00:00"
            /// 		"publicNetworkAccess" = true
            /// 	  }
            /// 	  "tags" = {}
            /// 	  "type" = "Microsoft.Automation/AutomationAccounts"
            /// 	}
            ///   ]
            /// }
            /// ]]></code></description>
            /// <description><strong>Map</strong>: A map where the key is the name for the result and the value is a JMESPath query string to filter the response. Here's an example. If it sets to <c>{"values": "value[].{name: name, publicNetworkAccess: properties.publicNetworkAccess}", "names": "value[].name"}</c>, it will set the following HCL object to the computed property output.
            ///
            /// <code><![CDATA[
            /// {
            /// 	"names" = [
            /// 		"example",
            /// 		"fredaccount01",
            /// 	]
            /// 	"values" = [
            /// 		{
            /// 		  "name" = "example"
            /// 		  "publicNetworkAccess" = true
            /// 		},
            /// 		{
            /// 		  "name" = "fredaccount01"
            /// 		  "publicNetworkAccess" = null
            /// 		},
            /// 	]
            /// }
            /// ]]></code></description>
            /// </list>
            ///
            /// To learn more about JMESPath, visit <a href="https://jmespath.org/">JMESPath</a>.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/azure/azapi/2.10.0/docs/data-sources/resource_list#response_export_values DataAzapiResourceList#response_export_values}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "responseExportValues", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, object>? ResponseExportValues
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, object>?>();
            }

            /// <summary>The retry object supports the following attributes:.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/azure/azapi/2.10.0/docs/data-sources/resource_list#retry DataAzapiResourceList#retry}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "retry", typeJson: "{\"fqn\":\"azapi.dataAzapiResourceList.DataAzapiResourceListRetry\"}", isOptional: true)]
            public azapi.DataAzapiResourceList.IDataAzapiResourceListRetry? Retry
            {
                get => GetInstanceProperty<azapi.DataAzapiResourceList.IDataAzapiResourceListRetry?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/azure/azapi/2.10.0/docs/data-sources/resource_list#timeouts DataAzapiResourceList#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azapi.dataAzapiResourceList.DataAzapiResourceListTimeouts\"}", isOptional: true)]
            public azapi.DataAzapiResourceList.IDataAzapiResourceListTimeouts? Timeouts
            {
                get => GetInstanceProperty<azapi.DataAzapiResourceList.IDataAzapiResourceListTimeouts?>();
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
