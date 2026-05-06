using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciContainerInstancesContainerInstance
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/container_instances_container_instance oci_container_instances_container_instance}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciContainerInstancesContainerInstance.DataOciContainerInstancesContainerInstance), fullyQualifiedName: "oci.dataOciContainerInstancesContainerInstance.DataOciContainerInstancesContainerInstance", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciContainerInstancesContainerInstance.DataOciContainerInstancesContainerInstanceConfig\"}}]")]
    public class DataOciContainerInstancesContainerInstance : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/container_instances_container_instance oci_container_instances_container_instance} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciContainerInstancesContainerInstance(Constructs.Construct scope, string id, oci.DataOciContainerInstancesContainerInstance.IDataOciContainerInstancesContainerInstanceConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciContainerInstancesContainerInstance.IDataOciContainerInstancesContainerInstanceConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciContainerInstancesContainerInstance(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciContainerInstancesContainerInstance(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciContainerInstancesContainerInstance resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciContainerInstancesContainerInstance to import.</param>
        /// <param name="importFromId">The id of the existing DataOciContainerInstancesContainerInstance that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciContainerInstancesContainerInstance to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciContainerInstancesContainerInstance to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/container_instances_container_instance#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciContainerInstancesContainerInstance that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciContainerInstancesContainerInstance to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciContainerInstancesContainerInstance.DataOciContainerInstancesContainerInstance), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(oci.DataOciContainerInstancesContainerInstance.DataOciContainerInstancesContainerInstance))!;

        [JsiiProperty(name: "availabilityDomain", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AvailabilityDomain
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "containerCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ContainerCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "containerRestartPolicy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ContainerRestartPolicy
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "containers", typeJson: "{\"fqn\":\"oci.dataOciContainerInstancesContainerInstance.DataOciContainerInstancesContainerInstanceContainersList\"}")]
        public virtual oci.DataOciContainerInstancesContainerInstance.DataOciContainerInstancesContainerInstanceContainersList Containers
        {
            get => GetInstanceProperty<oci.DataOciContainerInstancesContainerInstance.DataOciContainerInstancesContainerInstanceContainersList>()!;
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap DefinedTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dnsConfig", typeJson: "{\"fqn\":\"oci.dataOciContainerInstancesContainerInstance.DataOciContainerInstancesContainerInstanceDnsConfigList\"}")]
        public virtual oci.DataOciContainerInstancesContainerInstance.DataOciContainerInstancesContainerInstanceDnsConfigList DnsConfig
        {
            get => GetInstanceProperty<oci.DataOciContainerInstancesContainerInstance.DataOciContainerInstancesContainerInstanceDnsConfigList>()!;
        }

        [JsiiProperty(name: "faultDomain", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FaultDomain
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap FreeformTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "gracefulShutdownTimeoutInSeconds", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GracefulShutdownTimeoutInSeconds
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "imagePullSecrets", typeJson: "{\"fqn\":\"oci.dataOciContainerInstancesContainerInstance.DataOciContainerInstancesContainerInstanceImagePullSecretsList\"}")]
        public virtual oci.DataOciContainerInstancesContainerInstance.DataOciContainerInstancesContainerInstanceImagePullSecretsList ImagePullSecrets
        {
            get => GetInstanceProperty<oci.DataOciContainerInstancesContainerInstance.DataOciContainerInstancesContainerInstanceImagePullSecretsList>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "shape", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Shape
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "shapeConfig", typeJson: "{\"fqn\":\"oci.dataOciContainerInstancesContainerInstance.DataOciContainerInstancesContainerInstanceShapeConfigList\"}")]
        public virtual oci.DataOciContainerInstancesContainerInstance.DataOciContainerInstancesContainerInstanceShapeConfigList ShapeConfig
        {
            get => GetInstanceProperty<oci.DataOciContainerInstancesContainerInstance.DataOciContainerInstancesContainerInstanceShapeConfigList>()!;
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

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "vnics", typeJson: "{\"fqn\":\"oci.dataOciContainerInstancesContainerInstance.DataOciContainerInstancesContainerInstanceVnicsList\"}")]
        public virtual oci.DataOciContainerInstancesContainerInstance.DataOciContainerInstancesContainerInstanceVnicsList Vnics
        {
            get => GetInstanceProperty<oci.DataOciContainerInstancesContainerInstance.DataOciContainerInstancesContainerInstanceVnicsList>()!;
        }

        [JsiiProperty(name: "volumeCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double VolumeCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "volumes", typeJson: "{\"fqn\":\"oci.dataOciContainerInstancesContainerInstance.DataOciContainerInstancesContainerInstanceVolumesList\"}")]
        public virtual oci.DataOciContainerInstancesContainerInstance.DataOciContainerInstancesContainerInstanceVolumesList Volumes
        {
            get => GetInstanceProperty<oci.DataOciContainerInstancesContainerInstance.DataOciContainerInstancesContainerInstanceVolumesList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "containerInstanceIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ContainerInstanceIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "containerInstanceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ContainerInstanceId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
