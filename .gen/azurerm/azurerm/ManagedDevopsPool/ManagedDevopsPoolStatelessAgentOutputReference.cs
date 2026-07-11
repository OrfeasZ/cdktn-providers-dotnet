using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ManagedDevopsPool
{
    [JsiiClass(nativeType: typeof(azurerm.ManagedDevopsPool.ManagedDevopsPoolStatelessAgentOutputReference), fullyQualifiedName: "azurerm.managedDevopsPool.ManagedDevopsPoolStatelessAgentOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ManagedDevopsPoolStatelessAgentOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ManagedDevopsPoolStatelessAgentOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ManagedDevopsPoolStatelessAgentOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ManagedDevopsPoolStatelessAgentOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAutomaticResourcePrediction", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolStatelessAgentAutomaticResourcePrediction\"}}]")]
        public virtual void PutAutomaticResourcePrediction(azurerm.ManagedDevopsPool.IManagedDevopsPoolStatelessAgentAutomaticResourcePrediction @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.ManagedDevopsPool.IManagedDevopsPoolStatelessAgentAutomaticResourcePrediction)}, new object[]{@value});
        }

        [JsiiMethod(name: "putManualResourcePrediction", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolStatelessAgentManualResourcePrediction\"}}]")]
        public virtual void PutManualResourcePrediction(azurerm.ManagedDevopsPool.IManagedDevopsPoolStatelessAgentManualResourcePrediction @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.ManagedDevopsPool.IManagedDevopsPoolStatelessAgentManualResourcePrediction)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAutomaticResourcePrediction")]
        public virtual void ResetAutomaticResourcePrediction()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetManualResourcePrediction")]
        public virtual void ResetManualResourcePrediction()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "automaticResourcePrediction", typeJson: "{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolStatelessAgentAutomaticResourcePredictionOutputReference\"}")]
        public virtual azurerm.ManagedDevopsPool.ManagedDevopsPoolStatelessAgentAutomaticResourcePredictionOutputReference AutomaticResourcePrediction
        {
            get => GetInstanceProperty<azurerm.ManagedDevopsPool.ManagedDevopsPoolStatelessAgentAutomaticResourcePredictionOutputReference>()!;
        }

        [JsiiProperty(name: "manualResourcePrediction", typeJson: "{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolStatelessAgentManualResourcePredictionOutputReference\"}")]
        public virtual azurerm.ManagedDevopsPool.ManagedDevopsPoolStatelessAgentManualResourcePredictionOutputReference ManualResourcePrediction
        {
            get => GetInstanceProperty<azurerm.ManagedDevopsPool.ManagedDevopsPoolStatelessAgentManualResourcePredictionOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "automaticResourcePredictionInput", typeJson: "{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolStatelessAgentAutomaticResourcePrediction\"}", isOptional: true)]
        public virtual azurerm.ManagedDevopsPool.IManagedDevopsPoolStatelessAgentAutomaticResourcePrediction? AutomaticResourcePredictionInput
        {
            get => GetInstanceProperty<azurerm.ManagedDevopsPool.IManagedDevopsPoolStatelessAgentAutomaticResourcePrediction?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "manualResourcePredictionInput", typeJson: "{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolStatelessAgentManualResourcePrediction\"}", isOptional: true)]
        public virtual azurerm.ManagedDevopsPool.IManagedDevopsPoolStatelessAgentManualResourcePrediction? ManualResourcePredictionInput
        {
            get => GetInstanceProperty<azurerm.ManagedDevopsPool.IManagedDevopsPoolStatelessAgentManualResourcePrediction?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolStatelessAgent\"}", isOptional: true)]
        public virtual azurerm.ManagedDevopsPool.IManagedDevopsPoolStatelessAgent? InternalValue
        {
            get => GetInstanceProperty<azurerm.ManagedDevopsPool.IManagedDevopsPoolStatelessAgent?>();
            set => SetInstanceProperty(value);
        }
    }
}
