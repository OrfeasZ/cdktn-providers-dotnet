using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.FunctionTrigger
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/function_trigger scaleway_function_trigger}.</summary>
    [JsiiClass(nativeType: typeof(scaleway.FunctionTrigger.FunctionTrigger), fullyQualifiedName: "scaleway.functionTrigger.FunctionTrigger", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"scaleway.functionTrigger.FunctionTriggerConfig\"}}]")]
    public class FunctionTrigger : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/function_trigger scaleway_function_trigger} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public FunctionTrigger(Constructs.Construct scope, string id, scaleway.FunctionTrigger.IFunctionTriggerConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, scaleway.FunctionTrigger.IFunctionTriggerConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected FunctionTrigger(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected FunctionTrigger(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a FunctionTrigger resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the FunctionTrigger to import.</param>
        /// <param name="importFromId">The id of the existing FunctionTrigger that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the FunctionTrigger to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the FunctionTrigger to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/function_trigger#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing FunctionTrigger that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the FunctionTrigger to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(scaleway.FunctionTrigger.FunctionTrigger), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putNats", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"scaleway.functionTrigger.FunctionTriggerNats\"}}]")]
        public virtual void PutNats(scaleway.FunctionTrigger.IFunctionTriggerNats @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(scaleway.FunctionTrigger.IFunctionTriggerNats)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSqs", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"scaleway.functionTrigger.FunctionTriggerSqs\"}}]")]
        public virtual void PutSqs(scaleway.FunctionTrigger.IFunctionTriggerSqs @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(scaleway.FunctionTrigger.IFunctionTriggerSqs)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"scaleway.functionTrigger.FunctionTriggerTimeouts\"}}]")]
        public virtual void PutTimeouts(scaleway.FunctionTrigger.IFunctionTriggerTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(scaleway.FunctionTrigger.IFunctionTriggerTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetName")]
        public virtual void ResetName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNats")]
        public virtual void ResetNats()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRegion")]
        public virtual void ResetRegion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSqs")]
        public virtual void ResetSqs()
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
        = GetStaticProperty<string>(typeof(scaleway.FunctionTrigger.FunctionTrigger))!;

        [JsiiProperty(name: "nats", typeJson: "{\"fqn\":\"scaleway.functionTrigger.FunctionTriggerNatsOutputReference\"}")]
        public virtual scaleway.FunctionTrigger.FunctionTriggerNatsOutputReference Nats
        {
            get => GetInstanceProperty<scaleway.FunctionTrigger.FunctionTriggerNatsOutputReference>()!;
        }

        [JsiiProperty(name: "sqs", typeJson: "{\"fqn\":\"scaleway.functionTrigger.FunctionTriggerSqsOutputReference\"}")]
        public virtual scaleway.FunctionTrigger.FunctionTriggerSqsOutputReference Sqs
        {
            get => GetInstanceProperty<scaleway.FunctionTrigger.FunctionTriggerSqsOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"scaleway.functionTrigger.FunctionTriggerTimeoutsOutputReference\"}")]
        public virtual scaleway.FunctionTrigger.FunctionTriggerTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<scaleway.FunctionTrigger.FunctionTriggerTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "functionIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FunctionIdInput
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
        [JsiiProperty(name: "natsInput", typeJson: "{\"fqn\":\"scaleway.functionTrigger.FunctionTriggerNats\"}", isOptional: true)]
        public virtual scaleway.FunctionTrigger.IFunctionTriggerNats? NatsInput
        {
            get => GetInstanceProperty<scaleway.FunctionTrigger.IFunctionTriggerNats?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "regionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RegionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sqsInput", typeJson: "{\"fqn\":\"scaleway.functionTrigger.FunctionTriggerSqs\"}", isOptional: true)]
        public virtual scaleway.FunctionTrigger.IFunctionTriggerSqs? SqsInput
        {
            get => GetInstanceProperty<scaleway.FunctionTrigger.IFunctionTriggerSqs?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"scaleway.functionTrigger.FunctionTriggerTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "functionId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FunctionId
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
    }
}
