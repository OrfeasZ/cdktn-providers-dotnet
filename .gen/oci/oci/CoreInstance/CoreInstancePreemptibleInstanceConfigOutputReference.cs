using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreInstance
{
    [JsiiClass(nativeType: typeof(oci.CoreInstance.CoreInstancePreemptibleInstanceConfigOutputReference), fullyQualifiedName: "oci.coreInstance.CoreInstancePreemptibleInstanceConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CoreInstancePreemptibleInstanceConfigOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CoreInstancePreemptibleInstanceConfigOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected CoreInstancePreemptibleInstanceConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CoreInstancePreemptibleInstanceConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putPreemptionAction", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.coreInstance.CoreInstancePreemptibleInstanceConfigPreemptionAction\"}}]")]
        public virtual void PutPreemptionAction(oci.CoreInstance.ICoreInstancePreemptibleInstanceConfigPreemptionAction @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.CoreInstance.ICoreInstancePreemptibleInstanceConfigPreemptionAction)}, new object[]{@value});
        }

        [JsiiProperty(name: "preemptionAction", typeJson: "{\"fqn\":\"oci.coreInstance.CoreInstancePreemptibleInstanceConfigPreemptionActionOutputReference\"}")]
        public virtual oci.CoreInstance.CoreInstancePreemptibleInstanceConfigPreemptionActionOutputReference PreemptionAction
        {
            get => GetInstanceProperty<oci.CoreInstance.CoreInstancePreemptibleInstanceConfigPreemptionActionOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "preemptionActionInput", typeJson: "{\"fqn\":\"oci.coreInstance.CoreInstancePreemptibleInstanceConfigPreemptionAction\"}", isOptional: true)]
        public virtual oci.CoreInstance.ICoreInstancePreemptibleInstanceConfigPreemptionAction? PreemptionActionInput
        {
            get => GetInstanceProperty<oci.CoreInstance.ICoreInstancePreemptibleInstanceConfigPreemptionAction?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.coreInstance.CoreInstancePreemptibleInstanceConfig\"}", isOptional: true)]
        public virtual oci.CoreInstance.ICoreInstancePreemptibleInstanceConfig? InternalValue
        {
            get => GetInstanceProperty<oci.CoreInstance.ICoreInstancePreemptibleInstanceConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
