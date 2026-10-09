using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.Microvm
{
    [JsiiClass(nativeType: typeof(digitalocean.Microvm.MicrovmSourceOutputReference), fullyQualifiedName: "digitalocean.microvm.MicrovmSourceOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class MicrovmSourceOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public MicrovmSourceOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MicrovmSourceOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MicrovmSourceOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetCheckpointId")]
        public virtual void ResetCheckpointId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOciRef")]
        public virtual void ResetOciRef()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "checkpointIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CheckpointIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ociRefInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OciRefInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "checkpointId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CheckpointId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ociRef", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OciRef
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"digitalocean.microvm.MicrovmSource\"}", isOptional: true)]
        public virtual digitalocean.Microvm.IMicrovmSource? InternalValue
        {
            get => GetInstanceProperty<digitalocean.Microvm.IMicrovmSource?>();
            set => SetInstanceProperty(value);
        }
    }
}
