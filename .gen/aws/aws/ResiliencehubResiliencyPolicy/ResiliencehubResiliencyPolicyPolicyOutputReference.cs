using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ResiliencehubResiliencyPolicy
{
    [JsiiClass(nativeType: typeof(aws.ResiliencehubResiliencyPolicy.ResiliencehubResiliencyPolicyPolicyOutputReference), fullyQualifiedName: "aws.resiliencehubResiliencyPolicy.ResiliencehubResiliencyPolicyPolicyOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class ResiliencehubResiliencyPolicyPolicyOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public ResiliencehubResiliencyPolicyPolicyOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected ResiliencehubResiliencyPolicyPolicyOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ResiliencehubResiliencyPolicyPolicyOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAz", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.resiliencehubResiliencyPolicy.ResiliencehubResiliencyPolicyPolicyAz\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutAz(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.ResiliencehubResiliencyPolicy.IResiliencehubResiliencyPolicyPolicyAz[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.ResiliencehubResiliencyPolicy.IResiliencehubResiliencyPolicyPolicyAz).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.ResiliencehubResiliencyPolicy.IResiliencehubResiliencyPolicyPolicyAz).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putHardware", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.resiliencehubResiliencyPolicy.ResiliencehubResiliencyPolicyPolicyHardware\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutHardware(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.ResiliencehubResiliencyPolicy.IResiliencehubResiliencyPolicyPolicyHardware[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.ResiliencehubResiliencyPolicy.IResiliencehubResiliencyPolicyPolicyHardware).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.ResiliencehubResiliencyPolicy.IResiliencehubResiliencyPolicyPolicyHardware).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRegion", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.resiliencehubResiliencyPolicy.ResiliencehubResiliencyPolicyPolicyRegion\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutRegion(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.ResiliencehubResiliencyPolicy.IResiliencehubResiliencyPolicyPolicyRegion[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.ResiliencehubResiliencyPolicy.IResiliencehubResiliencyPolicyPolicyRegion).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.ResiliencehubResiliencyPolicy.IResiliencehubResiliencyPolicyPolicyRegion).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSoftwareAttribute", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.resiliencehubResiliencyPolicy.ResiliencehubResiliencyPolicyPolicySoftware\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutSoftwareAttribute(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.ResiliencehubResiliencyPolicy.IResiliencehubResiliencyPolicyPolicySoftware[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.ResiliencehubResiliencyPolicy.IResiliencehubResiliencyPolicyPolicySoftware).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.ResiliencehubResiliencyPolicy.IResiliencehubResiliencyPolicyPolicySoftware).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAz")]
        public virtual void ResetAz()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHardware")]
        public virtual void ResetHardware()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRegion")]
        public virtual void ResetRegion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSoftwareAttribute")]
        public virtual void ResetSoftwareAttribute()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "az", typeJson: "{\"fqn\":\"aws.resiliencehubResiliencyPolicy.ResiliencehubResiliencyPolicyPolicyAzList\"}")]
        public virtual aws.ResiliencehubResiliencyPolicy.ResiliencehubResiliencyPolicyPolicyAzList Az
        {
            get => GetInstanceProperty<aws.ResiliencehubResiliencyPolicy.ResiliencehubResiliencyPolicyPolicyAzList>()!;
        }

        [JsiiProperty(name: "hardware", typeJson: "{\"fqn\":\"aws.resiliencehubResiliencyPolicy.ResiliencehubResiliencyPolicyPolicyHardwareList\"}")]
        public virtual aws.ResiliencehubResiliencyPolicy.ResiliencehubResiliencyPolicyPolicyHardwareList Hardware
        {
            get => GetInstanceProperty<aws.ResiliencehubResiliencyPolicy.ResiliencehubResiliencyPolicyPolicyHardwareList>()!;
        }

        [JsiiProperty(name: "region", typeJson: "{\"fqn\":\"aws.resiliencehubResiliencyPolicy.ResiliencehubResiliencyPolicyPolicyRegionList\"}")]
        public virtual aws.ResiliencehubResiliencyPolicy.ResiliencehubResiliencyPolicyPolicyRegionList Region
        {
            get => GetInstanceProperty<aws.ResiliencehubResiliencyPolicy.ResiliencehubResiliencyPolicyPolicyRegionList>()!;
        }

        [JsiiProperty(name: "softwareAttribute", typeJson: "{\"fqn\":\"aws.resiliencehubResiliencyPolicy.ResiliencehubResiliencyPolicyPolicySoftwareList\"}")]
        public virtual aws.ResiliencehubResiliencyPolicy.ResiliencehubResiliencyPolicyPolicySoftwareList SoftwareAttribute
        {
            get => GetInstanceProperty<aws.ResiliencehubResiliencyPolicy.ResiliencehubResiliencyPolicyPolicySoftwareList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "azInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.resiliencehubResiliencyPolicy.ResiliencehubResiliencyPolicyPolicyAz\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? AzInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "hardwareInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.resiliencehubResiliencyPolicy.ResiliencehubResiliencyPolicyPolicyHardware\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? HardwareInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "regionInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.resiliencehubResiliencyPolicy.ResiliencehubResiliencyPolicyPolicyRegion\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? RegionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "softwareAttributeInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.resiliencehubResiliencyPolicy.ResiliencehubResiliencyPolicyPolicySoftware\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? SoftwareAttributeInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"aws.resiliencehubResiliencyPolicy.ResiliencehubResiliencyPolicyPolicy\"}]}}", isOptional: true)]
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
                        case aws.ResiliencehubResiliencyPolicy.IResiliencehubResiliencyPolicyPolicy cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.ResiliencehubResiliencyPolicy.IResiliencehubResiliencyPolicyPolicy).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
