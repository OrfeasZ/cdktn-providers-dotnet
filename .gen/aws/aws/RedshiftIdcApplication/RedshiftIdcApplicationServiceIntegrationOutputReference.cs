using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.RedshiftIdcApplication
{
    [JsiiClass(nativeType: typeof(aws.RedshiftIdcApplication.RedshiftIdcApplicationServiceIntegrationOutputReference), fullyQualifiedName: "aws.redshiftIdcApplication.RedshiftIdcApplicationServiceIntegrationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class RedshiftIdcApplicationServiceIntegrationOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public RedshiftIdcApplicationServiceIntegrationOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected RedshiftIdcApplicationServiceIntegrationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected RedshiftIdcApplicationServiceIntegrationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putLakeFormation", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.redshiftIdcApplication.RedshiftIdcApplicationServiceIntegrationLakeFormation\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutLakeFormation(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.RedshiftIdcApplication.IRedshiftIdcApplicationServiceIntegrationLakeFormation[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.RedshiftIdcApplication.IRedshiftIdcApplicationServiceIntegrationLakeFormation).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.RedshiftIdcApplication.IRedshiftIdcApplicationServiceIntegrationLakeFormation).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRedshift", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.redshiftIdcApplication.RedshiftIdcApplicationServiceIntegrationRedshift\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutRedshift(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.RedshiftIdcApplication.IRedshiftIdcApplicationServiceIntegrationRedshift[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.RedshiftIdcApplication.IRedshiftIdcApplicationServiceIntegrationRedshift).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.RedshiftIdcApplication.IRedshiftIdcApplicationServiceIntegrationRedshift).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putS3AccessGrants", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.redshiftIdcApplication.RedshiftIdcApplicationServiceIntegrationS3AccessGrants\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutS3AccessGrants(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.RedshiftIdcApplication.IRedshiftIdcApplicationServiceIntegrationS3AccessGrants[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.RedshiftIdcApplication.IRedshiftIdcApplicationServiceIntegrationS3AccessGrants).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.RedshiftIdcApplication.IRedshiftIdcApplicationServiceIntegrationS3AccessGrants).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetLakeFormation")]
        public virtual void ResetLakeFormation()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRedshift")]
        public virtual void ResetRedshift()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetS3AccessGrants")]
        public virtual void ResetS3AccessGrants()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "lakeFormation", typeJson: "{\"fqn\":\"aws.redshiftIdcApplication.RedshiftIdcApplicationServiceIntegrationLakeFormationList\"}")]
        public virtual aws.RedshiftIdcApplication.RedshiftIdcApplicationServiceIntegrationLakeFormationList LakeFormation
        {
            get => GetInstanceProperty<aws.RedshiftIdcApplication.RedshiftIdcApplicationServiceIntegrationLakeFormationList>()!;
        }

        [JsiiProperty(name: "redshift", typeJson: "{\"fqn\":\"aws.redshiftIdcApplication.RedshiftIdcApplicationServiceIntegrationRedshiftList\"}")]
        public virtual aws.RedshiftIdcApplication.RedshiftIdcApplicationServiceIntegrationRedshiftList Redshift
        {
            get => GetInstanceProperty<aws.RedshiftIdcApplication.RedshiftIdcApplicationServiceIntegrationRedshiftList>()!;
        }

        [JsiiProperty(name: "s3AccessGrants", typeJson: "{\"fqn\":\"aws.redshiftIdcApplication.RedshiftIdcApplicationServiceIntegrationS3AccessGrantsList\"}")]
        public virtual aws.RedshiftIdcApplication.RedshiftIdcApplicationServiceIntegrationS3AccessGrantsList S3AccessGrants
        {
            get => GetInstanceProperty<aws.RedshiftIdcApplication.RedshiftIdcApplicationServiceIntegrationS3AccessGrantsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "lakeFormationInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.redshiftIdcApplication.RedshiftIdcApplicationServiceIntegrationLakeFormation\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? LakeFormationInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "redshiftInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.redshiftIdcApplication.RedshiftIdcApplicationServiceIntegrationRedshift\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? RedshiftInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "s3AccessGrantsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.redshiftIdcApplication.RedshiftIdcApplicationServiceIntegrationS3AccessGrants\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? S3AccessGrantsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"aws.redshiftIdcApplication.RedshiftIdcApplicationServiceIntegration\"}]}}", isOptional: true)]
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
                        case aws.RedshiftIdcApplication.IRedshiftIdcApplicationServiceIntegration cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.RedshiftIdcApplication.IRedshiftIdcApplicationServiceIntegration).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
