using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.LogAnalyticsNamespaceIngestTimeRule
{
    [JsiiClass(nativeType: typeof(oci.LogAnalyticsNamespaceIngestTimeRule.LogAnalyticsNamespaceIngestTimeRuleConditionsOutputReference), fullyQualifiedName: "oci.logAnalyticsNamespaceIngestTimeRule.LogAnalyticsNamespaceIngestTimeRuleConditionsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class LogAnalyticsNamespaceIngestTimeRuleConditionsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public LogAnalyticsNamespaceIngestTimeRuleConditionsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected LogAnalyticsNamespaceIngestTimeRuleConditionsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LogAnalyticsNamespaceIngestTimeRuleConditionsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAdditionalConditions", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.logAnalyticsNamespaceIngestTimeRule.LogAnalyticsNamespaceIngestTimeRuleConditionsAdditionalConditions\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutAdditionalConditions(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.LogAnalyticsNamespaceIngestTimeRule.ILogAnalyticsNamespaceIngestTimeRuleConditionsAdditionalConditions[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.LogAnalyticsNamespaceIngestTimeRule.ILogAnalyticsNamespaceIngestTimeRuleConditionsAdditionalConditions).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.LogAnalyticsNamespaceIngestTimeRule.ILogAnalyticsNamespaceIngestTimeRuleConditionsAdditionalConditions).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAdditionalConditions")]
        public virtual void ResetAdditionalConditions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "additionalConditions", typeJson: "{\"fqn\":\"oci.logAnalyticsNamespaceIngestTimeRule.LogAnalyticsNamespaceIngestTimeRuleConditionsAdditionalConditionsList\"}")]
        public virtual oci.LogAnalyticsNamespaceIngestTimeRule.LogAnalyticsNamespaceIngestTimeRuleConditionsAdditionalConditionsList AdditionalConditions
        {
            get => GetInstanceProperty<oci.LogAnalyticsNamespaceIngestTimeRule.LogAnalyticsNamespaceIngestTimeRuleConditionsAdditionalConditionsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "additionalConditionsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.logAnalyticsNamespaceIngestTimeRule.LogAnalyticsNamespaceIngestTimeRuleConditionsAdditionalConditions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? AdditionalConditionsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "fieldNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FieldNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "fieldOperatorInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FieldOperatorInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "fieldValueInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FieldValueInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "kindInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? KindInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "fieldName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FieldName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "fieldOperator", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FieldOperator
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "fieldValue", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FieldValue
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "kind", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Kind
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.logAnalyticsNamespaceIngestTimeRule.LogAnalyticsNamespaceIngestTimeRuleConditions\"}", isOptional: true)]
        public virtual oci.LogAnalyticsNamespaceIngestTimeRule.ILogAnalyticsNamespaceIngestTimeRuleConditions? InternalValue
        {
            get => GetInstanceProperty<oci.LogAnalyticsNamespaceIngestTimeRule.ILogAnalyticsNamespaceIngestTimeRuleConditions?>();
            set => SetInstanceProperty(value);
        }
    }
}
