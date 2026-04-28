using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.IotRoute
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/iot_route scaleway_iot_route}.</summary>
    [JsiiClass(nativeType: typeof(scaleway.IotRoute.IotRoute), fullyQualifiedName: "scaleway.iotRoute.IotRoute", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"scaleway.iotRoute.IotRouteConfig\"}}]")]
    public class IotRoute : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/iot_route scaleway_iot_route} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public IotRoute(Constructs.Construct scope, string id, scaleway.IotRoute.IIotRouteConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, scaleway.IotRoute.IIotRouteConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected IotRoute(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected IotRoute(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a IotRoute resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the IotRoute to import.</param>
        /// <param name="importFromId">The id of the existing IotRoute that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the IotRoute to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the IotRoute to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/iot_route#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing IotRoute that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the IotRoute to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(scaleway.IotRoute.IotRoute), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putDatabase", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"scaleway.iotRoute.IotRouteDatabase\"}}]")]
        public virtual void PutDatabase(scaleway.IotRoute.IIotRouteDatabase @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(scaleway.IotRoute.IIotRouteDatabase)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRest", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"scaleway.iotRoute.IotRouteRest\"}}]")]
        public virtual void PutRest(scaleway.IotRoute.IIotRouteRest @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(scaleway.IotRoute.IIotRouteRest)}, new object[]{@value});
        }

        [JsiiMethod(name: "putS3", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"scaleway.iotRoute.IotRouteS3\"}}]")]
        public virtual void PutS3(scaleway.IotRoute.IIotRouteS3 @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(scaleway.IotRoute.IIotRouteS3)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"scaleway.iotRoute.IotRouteTimeouts\"}}]")]
        public virtual void PutTimeouts(scaleway.IotRoute.IIotRouteTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(scaleway.IotRoute.IIotRouteTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDatabase")]
        public virtual void ResetDatabase()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRegion")]
        public virtual void ResetRegion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRest")]
        public virtual void ResetRest()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetS3")]
        public virtual void ResetS3()
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
        = GetStaticProperty<string>(typeof(scaleway.IotRoute.IotRoute))!;

        [JsiiProperty(name: "createdAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "database", typeJson: "{\"fqn\":\"scaleway.iotRoute.IotRouteDatabaseOutputReference\"}")]
        public virtual scaleway.IotRoute.IotRouteDatabaseOutputReference Database
        {
            get => GetInstanceProperty<scaleway.IotRoute.IotRouteDatabaseOutputReference>()!;
        }

        [JsiiProperty(name: "rest", typeJson: "{\"fqn\":\"scaleway.iotRoute.IotRouteRestOutputReference\"}")]
        public virtual scaleway.IotRoute.IotRouteRestOutputReference Rest
        {
            get => GetInstanceProperty<scaleway.IotRoute.IotRouteRestOutputReference>()!;
        }

        [JsiiProperty(name: "s3", typeJson: "{\"fqn\":\"scaleway.iotRoute.IotRouteS3OutputReference\"}")]
        public virtual scaleway.IotRoute.IotRouteS3OutputReference S3
        {
            get => GetInstanceProperty<scaleway.IotRoute.IotRouteS3OutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"scaleway.iotRoute.IotRouteTimeoutsOutputReference\"}")]
        public virtual scaleway.IotRoute.IotRouteTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<scaleway.IotRoute.IotRouteTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "databaseInput", typeJson: "{\"fqn\":\"scaleway.iotRoute.IotRouteDatabase\"}", isOptional: true)]
        public virtual scaleway.IotRoute.IIotRouteDatabase? DatabaseInput
        {
            get => GetInstanceProperty<scaleway.IotRoute.IIotRouteDatabase?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "hubIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? HubIdInput
        {
            get => GetInstanceProperty<string?>();
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
        [JsiiProperty(name: "regionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RegionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "restInput", typeJson: "{\"fqn\":\"scaleway.iotRoute.IotRouteRest\"}", isOptional: true)]
        public virtual scaleway.IotRoute.IIotRouteRest? RestInput
        {
            get => GetInstanceProperty<scaleway.IotRoute.IIotRouteRest?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "s3Input", typeJson: "{\"fqn\":\"scaleway.iotRoute.IotRouteS3\"}", isOptional: true)]
        public virtual scaleway.IotRoute.IIotRouteS3? S3Input
        {
            get => GetInstanceProperty<scaleway.IotRoute.IIotRouteS3?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"scaleway.iotRoute.IotRouteTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "topicInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TopicInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "hubId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HubId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
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

        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Region
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "topic", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Topic
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
