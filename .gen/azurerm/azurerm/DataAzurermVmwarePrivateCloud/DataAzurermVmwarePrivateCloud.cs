using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermVmwarePrivateCloud
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/data-sources/vmware_private_cloud azurerm_vmware_private_cloud}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.DataAzurermVmwarePrivateCloud.DataAzurermVmwarePrivateCloud), fullyQualifiedName: "azurerm.dataAzurermVmwarePrivateCloud.DataAzurermVmwarePrivateCloud", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.dataAzurermVmwarePrivateCloud.DataAzurermVmwarePrivateCloudConfig\"}}]")]
    public class DataAzurermVmwarePrivateCloud : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/data-sources/vmware_private_cloud azurerm_vmware_private_cloud} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAzurermVmwarePrivateCloud(Constructs.Construct scope, string id, azurerm.DataAzurermVmwarePrivateCloud.IDataAzurermVmwarePrivateCloudConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.DataAzurermVmwarePrivateCloud.IDataAzurermVmwarePrivateCloudConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermVmwarePrivateCloud(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermVmwarePrivateCloud(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataAzurermVmwarePrivateCloud resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataAzurermVmwarePrivateCloud to import.</param>
        /// <param name="importFromId">The id of the existing DataAzurermVmwarePrivateCloud that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataAzurermVmwarePrivateCloud to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataAzurermVmwarePrivateCloud to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/data-sources/vmware_private_cloud#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataAzurermVmwarePrivateCloud that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataAzurermVmwarePrivateCloud to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(azurerm.DataAzurermVmwarePrivateCloud.DataAzurermVmwarePrivateCloud), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.dataAzurermVmwarePrivateCloud.DataAzurermVmwarePrivateCloudTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.DataAzurermVmwarePrivateCloud.IDataAzurermVmwarePrivateCloudTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.DataAzurermVmwarePrivateCloud.IDataAzurermVmwarePrivateCloudTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiMethod(name: "synthesizeHclAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeHclAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(azurerm.DataAzurermVmwarePrivateCloud.DataAzurermVmwarePrivateCloud))!;

        [JsiiProperty(name: "circuit", typeJson: "{\"fqn\":\"azurerm.dataAzurermVmwarePrivateCloud.DataAzurermVmwarePrivateCloudCircuitList\"}")]
        public virtual azurerm.DataAzurermVmwarePrivateCloud.DataAzurermVmwarePrivateCloudCircuitList Circuit
        {
            get => GetInstanceProperty<azurerm.DataAzurermVmwarePrivateCloud.DataAzurermVmwarePrivateCloudCircuitList>()!;
        }

        [JsiiProperty(name: "hcxCloudManagerEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HcxCloudManagerEndpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "internetConnectionEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable InternetConnectionEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Location
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "managementCluster", typeJson: "{\"fqn\":\"azurerm.dataAzurermVmwarePrivateCloud.DataAzurermVmwarePrivateCloudManagementClusterList\"}")]
        public virtual azurerm.DataAzurermVmwarePrivateCloud.DataAzurermVmwarePrivateCloudManagementClusterList ManagementCluster
        {
            get => GetInstanceProperty<azurerm.DataAzurermVmwarePrivateCloud.DataAzurermVmwarePrivateCloudManagementClusterList>()!;
        }

        [JsiiProperty(name: "managementSubnetCidr", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ManagementSubnetCidr
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "networkSubnetCidr", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NetworkSubnetCidr
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "nsxtCertificateThumbprint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NsxtCertificateThumbprint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "nsxtManagerEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NsxtManagerEndpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "provisioningSubnetCidr", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProvisioningSubnetCidr
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "skuName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SkuName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap Tags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.dataAzurermVmwarePrivateCloud.DataAzurermVmwarePrivateCloudTimeoutsOutputReference\"}")]
        public virtual azurerm.DataAzurermVmwarePrivateCloud.DataAzurermVmwarePrivateCloudTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.DataAzurermVmwarePrivateCloud.DataAzurermVmwarePrivateCloudTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "vcenterCertificateThumbprint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VcenterCertificateThumbprint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "vcsaEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VcsaEndpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "vmotionSubnetCidr", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VmotionSubnetCidr
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceGroupNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ResourceGroupNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="azurerm.DataAzurermVmwarePrivateCloud.IDataAzurermVmwarePrivateCloudTimeouts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"azurerm.dataAzurermVmwarePrivateCloud.DataAzurermVmwarePrivateCloudTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "resourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceGroupName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
