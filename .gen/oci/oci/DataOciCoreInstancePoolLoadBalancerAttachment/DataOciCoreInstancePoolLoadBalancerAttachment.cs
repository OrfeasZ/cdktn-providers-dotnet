using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciCoreInstancePoolLoadBalancerAttachment
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/core_instance_pool_load_balancer_attachment oci_core_instance_pool_load_balancer_attachment}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciCoreInstancePoolLoadBalancerAttachment.DataOciCoreInstancePoolLoadBalancerAttachment), fullyQualifiedName: "oci.dataOciCoreInstancePoolLoadBalancerAttachment.DataOciCoreInstancePoolLoadBalancerAttachment", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciCoreInstancePoolLoadBalancerAttachment.DataOciCoreInstancePoolLoadBalancerAttachmentConfig\"}}]")]
    public class DataOciCoreInstancePoolLoadBalancerAttachment : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/core_instance_pool_load_balancer_attachment oci_core_instance_pool_load_balancer_attachment} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciCoreInstancePoolLoadBalancerAttachment(Constructs.Construct scope, string id, oci.DataOciCoreInstancePoolLoadBalancerAttachment.IDataOciCoreInstancePoolLoadBalancerAttachmentConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciCoreInstancePoolLoadBalancerAttachment.IDataOciCoreInstancePoolLoadBalancerAttachmentConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciCoreInstancePoolLoadBalancerAttachment(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciCoreInstancePoolLoadBalancerAttachment(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciCoreInstancePoolLoadBalancerAttachment resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciCoreInstancePoolLoadBalancerAttachment to import.</param>
        /// <param name="importFromId">The id of the existing DataOciCoreInstancePoolLoadBalancerAttachment that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciCoreInstancePoolLoadBalancerAttachment to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciCoreInstancePoolLoadBalancerAttachment to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/core_instance_pool_load_balancer_attachment#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciCoreInstancePoolLoadBalancerAttachment that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciCoreInstancePoolLoadBalancerAttachment to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciCoreInstancePoolLoadBalancerAttachment.DataOciCoreInstancePoolLoadBalancerAttachment), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
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
        = GetStaticProperty<string>(typeof(oci.DataOciCoreInstancePoolLoadBalancerAttachment.DataOciCoreInstancePoolLoadBalancerAttachment))!;

        [JsiiProperty(name: "backendSetName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BackendSetName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "loadBalancerId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LoadBalancerId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Port
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "vnicSelection", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VnicSelection
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
        [JsiiProperty(name: "instancePoolIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? InstancePoolIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "instancePoolLoadBalancerAttachmentIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? InstancePoolLoadBalancerAttachmentIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "instancePoolId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InstancePoolId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "instancePoolLoadBalancerAttachmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InstancePoolLoadBalancerAttachmentId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
