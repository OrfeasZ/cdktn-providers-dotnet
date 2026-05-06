using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ComputeCloudAtCustomerCccInfrastructure
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/compute_cloud_at_customer_ccc_infrastructure oci_compute_cloud_at_customer_ccc_infrastructure}.</summary>
    [JsiiClass(nativeType: typeof(oci.ComputeCloudAtCustomerCccInfrastructure.ComputeCloudAtCustomerCccInfrastructure), fullyQualifiedName: "oci.computeCloudAtCustomerCccInfrastructure.ComputeCloudAtCustomerCccInfrastructure", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.computeCloudAtCustomerCccInfrastructure.ComputeCloudAtCustomerCccInfrastructureConfig\"}}]")]
    public class ComputeCloudAtCustomerCccInfrastructure : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/compute_cloud_at_customer_ccc_infrastructure oci_compute_cloud_at_customer_ccc_infrastructure} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public ComputeCloudAtCustomerCccInfrastructure(Constructs.Construct scope, string id, oci.ComputeCloudAtCustomerCccInfrastructure.IComputeCloudAtCustomerCccInfrastructureConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.ComputeCloudAtCustomerCccInfrastructure.IComputeCloudAtCustomerCccInfrastructureConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ComputeCloudAtCustomerCccInfrastructure(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ComputeCloudAtCustomerCccInfrastructure(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a ComputeCloudAtCustomerCccInfrastructure resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the ComputeCloudAtCustomerCccInfrastructure to import.</param>
        /// <param name="importFromId">The id of the existing ComputeCloudAtCustomerCccInfrastructure that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the ComputeCloudAtCustomerCccInfrastructure to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the ComputeCloudAtCustomerCccInfrastructure to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/compute_cloud_at_customer_ccc_infrastructure#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing ComputeCloudAtCustomerCccInfrastructure that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the ComputeCloudAtCustomerCccInfrastructure to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.ComputeCloudAtCustomerCccInfrastructure.ComputeCloudAtCustomerCccInfrastructure), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.computeCloudAtCustomerCccInfrastructure.ComputeCloudAtCustomerCccInfrastructureTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.ComputeCloudAtCustomerCccInfrastructure.IComputeCloudAtCustomerCccInfrastructureTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.ComputeCloudAtCustomerCccInfrastructure.IComputeCloudAtCustomerCccInfrastructureTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCccUpgradeScheduleId")]
        public virtual void ResetCccUpgradeScheduleId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetConnectionDetails")]
        public virtual void ResetConnectionDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetConnectionState")]
        public virtual void ResetConnectionState()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDefinedTags")]
        public virtual void ResetDefinedTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFreeformTags")]
        public virtual void ResetFreeformTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
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
        = GetStaticProperty<string>(typeof(oci.ComputeCloudAtCustomerCccInfrastructure.ComputeCloudAtCustomerCccInfrastructure))!;

        [JsiiProperty(name: "infrastructureInventory", typeJson: "{\"fqn\":\"oci.computeCloudAtCustomerCccInfrastructure.ComputeCloudAtCustomerCccInfrastructureInfrastructureInventoryList\"}")]
        public virtual oci.ComputeCloudAtCustomerCccInfrastructure.ComputeCloudAtCustomerCccInfrastructureInfrastructureInventoryList InfrastructureInventory
        {
            get => GetInstanceProperty<oci.ComputeCloudAtCustomerCccInfrastructure.ComputeCloudAtCustomerCccInfrastructureInfrastructureInventoryList>()!;
        }

        [JsiiProperty(name: "infrastructureNetworkConfiguration", typeJson: "{\"fqn\":\"oci.computeCloudAtCustomerCccInfrastructure.ComputeCloudAtCustomerCccInfrastructureInfrastructureNetworkConfigurationList\"}")]
        public virtual oci.ComputeCloudAtCustomerCccInfrastructure.ComputeCloudAtCustomerCccInfrastructureInfrastructureNetworkConfigurationList InfrastructureNetworkConfiguration
        {
            get => GetInstanceProperty<oci.ComputeCloudAtCustomerCccInfrastructure.ComputeCloudAtCustomerCccInfrastructureInfrastructureNetworkConfigurationList>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "provisioningFingerprint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProvisioningFingerprint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "provisioningPin", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProvisioningPin
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "shortName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ShortName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "systemTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap SystemTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.computeCloudAtCustomerCccInfrastructure.ComputeCloudAtCustomerCccInfrastructureTimeoutsOutputReference\"}")]
        public virtual oci.ComputeCloudAtCustomerCccInfrastructure.ComputeCloudAtCustomerCccInfrastructureTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.ComputeCloudAtCustomerCccInfrastructure.ComputeCloudAtCustomerCccInfrastructureTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "upgradeInformation", typeJson: "{\"fqn\":\"oci.computeCloudAtCustomerCccInfrastructure.ComputeCloudAtCustomerCccInfrastructureUpgradeInformationList\"}")]
        public virtual oci.ComputeCloudAtCustomerCccInfrastructure.ComputeCloudAtCustomerCccInfrastructureUpgradeInformationList UpgradeInformation
        {
            get => GetInstanceProperty<oci.ComputeCloudAtCustomerCccInfrastructure.ComputeCloudAtCustomerCccInfrastructureUpgradeInformationList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "cccUpgradeScheduleIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CccUpgradeScheduleIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "compartmentIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CompartmentIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "connectionDetailsInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ConnectionDetailsInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "connectionStateInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ConnectionStateInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "definedTagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? DefinedTagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "displayNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DisplayNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "freeformTagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? FreeformTagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "subnetIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SubnetIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.computeCloudAtCustomerCccInfrastructure.ComputeCloudAtCustomerCccInfrastructureTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "cccUpgradeScheduleId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CccUpgradeScheduleId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "connectionDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConnectionDetails
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "connectionState", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConnectionState
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> DefinedTags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> FreeformTags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubnetId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
