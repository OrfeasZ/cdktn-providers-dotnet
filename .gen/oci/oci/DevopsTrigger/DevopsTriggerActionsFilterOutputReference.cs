using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DevopsTrigger
{
    [JsiiClass(nativeType: typeof(oci.DevopsTrigger.DevopsTriggerActionsFilterOutputReference), fullyQualifiedName: "oci.devopsTrigger.DevopsTriggerActionsFilterOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DevopsTriggerActionsFilterOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DevopsTriggerActionsFilterOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DevopsTriggerActionsFilterOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DevopsTriggerActionsFilterOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putExclude", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.devopsTrigger.DevopsTriggerActionsFilterExclude\"}}]")]
        public virtual void PutExclude(oci.DevopsTrigger.IDevopsTriggerActionsFilterExclude @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DevopsTrigger.IDevopsTriggerActionsFilterExclude)}, new object[]{@value});
        }

        [JsiiMethod(name: "putInclude", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.devopsTrigger.DevopsTriggerActionsFilterInclude\"}}]")]
        public virtual void PutInclude(oci.DevopsTrigger.IDevopsTriggerActionsFilterInclude @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DevopsTrigger.IDevopsTriggerActionsFilterInclude)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetEvents")]
        public virtual void ResetEvents()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetExclude")]
        public virtual void ResetExclude()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInclude")]
        public virtual void ResetInclude()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "exclude", typeJson: "{\"fqn\":\"oci.devopsTrigger.DevopsTriggerActionsFilterExcludeOutputReference\"}")]
        public virtual oci.DevopsTrigger.DevopsTriggerActionsFilterExcludeOutputReference Exclude
        {
            get => GetInstanceProperty<oci.DevopsTrigger.DevopsTriggerActionsFilterExcludeOutputReference>()!;
        }

        [JsiiProperty(name: "include", typeJson: "{\"fqn\":\"oci.devopsTrigger.DevopsTriggerActionsFilterIncludeOutputReference\"}")]
        public virtual oci.DevopsTrigger.DevopsTriggerActionsFilterIncludeOutputReference Include
        {
            get => GetInstanceProperty<oci.DevopsTrigger.DevopsTriggerActionsFilterIncludeOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "eventsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? EventsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "excludeInput", typeJson: "{\"fqn\":\"oci.devopsTrigger.DevopsTriggerActionsFilterExclude\"}", isOptional: true)]
        public virtual oci.DevopsTrigger.IDevopsTriggerActionsFilterExclude? ExcludeInput
        {
            get => GetInstanceProperty<oci.DevopsTrigger.IDevopsTriggerActionsFilterExclude?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "includeInput", typeJson: "{\"fqn\":\"oci.devopsTrigger.DevopsTriggerActionsFilterInclude\"}", isOptional: true)]
        public virtual oci.DevopsTrigger.IDevopsTriggerActionsFilterInclude? IncludeInput
        {
            get => GetInstanceProperty<oci.DevopsTrigger.IDevopsTriggerActionsFilterInclude?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "triggerSourceInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TriggerSourceInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "events", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Events
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "triggerSource", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TriggerSource
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.devopsTrigger.DevopsTriggerActionsFilter\"}", isOptional: true)]
        public virtual oci.DevopsTrigger.IDevopsTriggerActionsFilter? InternalValue
        {
            get => GetInstanceProperty<oci.DevopsTrigger.IDevopsTriggerActionsFilter?>();
            set => SetInstanceProperty(value);
        }
    }
}
