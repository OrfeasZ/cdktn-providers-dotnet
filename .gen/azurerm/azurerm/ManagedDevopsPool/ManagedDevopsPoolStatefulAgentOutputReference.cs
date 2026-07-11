using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ManagedDevopsPool
{
    [JsiiClass(nativeType: typeof(azurerm.ManagedDevopsPool.ManagedDevopsPoolStatefulAgentOutputReference), fullyQualifiedName: "azurerm.managedDevopsPool.ManagedDevopsPoolStatefulAgentOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ManagedDevopsPoolStatefulAgentOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ManagedDevopsPoolStatefulAgentOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ManagedDevopsPoolStatefulAgentOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ManagedDevopsPoolStatefulAgentOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAutomaticResourcePrediction", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolStatefulAgentAutomaticResourcePrediction\"}}]")]
        public virtual void PutAutomaticResourcePrediction(azurerm.ManagedDevopsPool.IManagedDevopsPoolStatefulAgentAutomaticResourcePrediction @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.ManagedDevopsPool.IManagedDevopsPoolStatefulAgentAutomaticResourcePrediction)}, new object[]{@value});
        }

        [JsiiMethod(name: "putManualResourcePrediction", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolStatefulAgentManualResourcePrediction\"}}]")]
        public virtual void PutManualResourcePrediction(azurerm.ManagedDevopsPool.IManagedDevopsPoolStatefulAgentManualResourcePrediction @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.ManagedDevopsPool.IManagedDevopsPoolStatefulAgentManualResourcePrediction)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAutomaticResourcePrediction")]
        public virtual void ResetAutomaticResourcePrediction()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGracePeriodTimeSpan")]
        public virtual void ResetGracePeriodTimeSpan()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetManualResourcePrediction")]
        public virtual void ResetManualResourcePrediction()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaximumAgentLifetime")]
        public virtual void ResetMaximumAgentLifetime()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "automaticResourcePrediction", typeJson: "{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolStatefulAgentAutomaticResourcePredictionOutputReference\"}")]
        public virtual azurerm.ManagedDevopsPool.ManagedDevopsPoolStatefulAgentAutomaticResourcePredictionOutputReference AutomaticResourcePrediction
        {
            get => GetInstanceProperty<azurerm.ManagedDevopsPool.ManagedDevopsPoolStatefulAgentAutomaticResourcePredictionOutputReference>()!;
        }

        [JsiiProperty(name: "manualResourcePrediction", typeJson: "{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolStatefulAgentManualResourcePredictionOutputReference\"}")]
        public virtual azurerm.ManagedDevopsPool.ManagedDevopsPoolStatefulAgentManualResourcePredictionOutputReference ManualResourcePrediction
        {
            get => GetInstanceProperty<azurerm.ManagedDevopsPool.ManagedDevopsPoolStatefulAgentManualResourcePredictionOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "automaticResourcePredictionInput", typeJson: "{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolStatefulAgentAutomaticResourcePrediction\"}", isOptional: true)]
        public virtual azurerm.ManagedDevopsPool.IManagedDevopsPoolStatefulAgentAutomaticResourcePrediction? AutomaticResourcePredictionInput
        {
            get => GetInstanceProperty<azurerm.ManagedDevopsPool.IManagedDevopsPoolStatefulAgentAutomaticResourcePrediction?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "gracePeriodTimeSpanInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? GracePeriodTimeSpanInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "manualResourcePredictionInput", typeJson: "{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolStatefulAgentManualResourcePrediction\"}", isOptional: true)]
        public virtual azurerm.ManagedDevopsPool.IManagedDevopsPoolStatefulAgentManualResourcePrediction? ManualResourcePredictionInput
        {
            get => GetInstanceProperty<azurerm.ManagedDevopsPool.IManagedDevopsPoolStatefulAgentManualResourcePrediction?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maximumAgentLifetimeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MaximumAgentLifetimeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "gracePeriodTimeSpan", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GracePeriodTimeSpan
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maximumAgentLifetime", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MaximumAgentLifetime
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolStatefulAgent\"}", isOptional: true)]
        public virtual azurerm.ManagedDevopsPool.IManagedDevopsPoolStatefulAgent? InternalValue
        {
            get => GetInstanceProperty<azurerm.ManagedDevopsPool.IManagedDevopsPoolStatefulAgent?>();
            set => SetInstanceProperty(value);
        }
    }
}
