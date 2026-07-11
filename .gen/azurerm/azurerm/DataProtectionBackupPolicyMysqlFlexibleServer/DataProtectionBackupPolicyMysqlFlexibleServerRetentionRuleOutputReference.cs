using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataProtectionBackupPolicyMysqlFlexibleServer
{
    [JsiiClass(nativeType: typeof(azurerm.DataProtectionBackupPolicyMysqlFlexibleServer.DataProtectionBackupPolicyMysqlFlexibleServerRetentionRuleOutputReference), fullyQualifiedName: "azurerm.dataProtectionBackupPolicyMysqlFlexibleServer.DataProtectionBackupPolicyMysqlFlexibleServerRetentionRuleOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataProtectionBackupPolicyMysqlFlexibleServerRetentionRuleOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataProtectionBackupPolicyMysqlFlexibleServerRetentionRuleOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataProtectionBackupPolicyMysqlFlexibleServerRetentionRuleOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataProtectionBackupPolicyMysqlFlexibleServerRetentionRuleOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCriteria", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.dataProtectionBackupPolicyMysqlFlexibleServer.DataProtectionBackupPolicyMysqlFlexibleServerRetentionRuleCriteria\"}}]")]
        public virtual void PutCriteria(azurerm.DataProtectionBackupPolicyMysqlFlexibleServer.IDataProtectionBackupPolicyMysqlFlexibleServerRetentionRuleCriteria @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.DataProtectionBackupPolicyMysqlFlexibleServer.IDataProtectionBackupPolicyMysqlFlexibleServerRetentionRuleCriteria)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.DataProtectionBackupPolicyMysqlFlexibleServer.IDataProtectionBackupPolicyMysqlFlexibleServerRetentionRuleLifeCycle" />)[]</param>
        [JsiiMethod(name: "putLifeCycle", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.dataProtectionBackupPolicyMysqlFlexibleServer.DataProtectionBackupPolicyMysqlFlexibleServerRetentionRuleLifeCycle\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutLifeCycle(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.DataProtectionBackupPolicyMysqlFlexibleServer.IDataProtectionBackupPolicyMysqlFlexibleServerRetentionRuleLifeCycle[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.DataProtectionBackupPolicyMysqlFlexibleServer.IDataProtectionBackupPolicyMysqlFlexibleServerRetentionRuleLifeCycle).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.DataProtectionBackupPolicyMysqlFlexibleServer.IDataProtectionBackupPolicyMysqlFlexibleServerRetentionRuleLifeCycle).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiProperty(name: "criteria", typeJson: "{\"fqn\":\"azurerm.dataProtectionBackupPolicyMysqlFlexibleServer.DataProtectionBackupPolicyMysqlFlexibleServerRetentionRuleCriteriaOutputReference\"}")]
        public virtual azurerm.DataProtectionBackupPolicyMysqlFlexibleServer.DataProtectionBackupPolicyMysqlFlexibleServerRetentionRuleCriteriaOutputReference Criteria
        {
            get => GetInstanceProperty<azurerm.DataProtectionBackupPolicyMysqlFlexibleServer.DataProtectionBackupPolicyMysqlFlexibleServerRetentionRuleCriteriaOutputReference>()!;
        }

        [JsiiProperty(name: "lifeCycle", typeJson: "{\"fqn\":\"azurerm.dataProtectionBackupPolicyMysqlFlexibleServer.DataProtectionBackupPolicyMysqlFlexibleServerRetentionRuleLifeCycleList\"}")]
        public virtual azurerm.DataProtectionBackupPolicyMysqlFlexibleServer.DataProtectionBackupPolicyMysqlFlexibleServerRetentionRuleLifeCycleList LifeCycle
        {
            get => GetInstanceProperty<azurerm.DataProtectionBackupPolicyMysqlFlexibleServer.DataProtectionBackupPolicyMysqlFlexibleServerRetentionRuleLifeCycleList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "criteriaInput", typeJson: "{\"fqn\":\"azurerm.dataProtectionBackupPolicyMysqlFlexibleServer.DataProtectionBackupPolicyMysqlFlexibleServerRetentionRuleCriteria\"}", isOptional: true)]
        public virtual azurerm.DataProtectionBackupPolicyMysqlFlexibleServer.IDataProtectionBackupPolicyMysqlFlexibleServerRetentionRuleCriteria? CriteriaInput
        {
            get => GetInstanceProperty<azurerm.DataProtectionBackupPolicyMysqlFlexibleServer.IDataProtectionBackupPolicyMysqlFlexibleServerRetentionRuleCriteria?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.DataProtectionBackupPolicyMysqlFlexibleServer.IDataProtectionBackupPolicyMysqlFlexibleServerRetentionRuleLifeCycle" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lifeCycleInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.dataProtectionBackupPolicyMysqlFlexibleServer.DataProtectionBackupPolicyMysqlFlexibleServerRetentionRuleLifeCycle\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? LifeCycleInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "priorityInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? PriorityInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Priority
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="azurerm.DataProtectionBackupPolicyMysqlFlexibleServer.IDataProtectionBackupPolicyMysqlFlexibleServerRetentionRule" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"azurerm.dataProtectionBackupPolicyMysqlFlexibleServer.DataProtectionBackupPolicyMysqlFlexibleServerRetentionRule\"}]}}", isOptional: true)]
        public virtual object? InternalValue
        {
            get => GetInstanceProperty<object?>();
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.DataProtectionBackupPolicyMysqlFlexibleServer.IDataProtectionBackupPolicyMysqlFlexibleServerRetentionRule cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.DataProtectionBackupPolicyMysqlFlexibleServer.IDataProtectionBackupPolicyMysqlFlexibleServerRetentionRule).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
