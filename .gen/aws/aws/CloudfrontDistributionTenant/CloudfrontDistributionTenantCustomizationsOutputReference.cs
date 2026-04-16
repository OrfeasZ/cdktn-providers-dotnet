using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudfrontDistributionTenant
{
    [JsiiClass(nativeType: typeof(aws.CloudfrontDistributionTenant.CloudfrontDistributionTenantCustomizationsOutputReference), fullyQualifiedName: "aws.cloudfrontDistributionTenant.CloudfrontDistributionTenantCustomizationsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class CloudfrontDistributionTenantCustomizationsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public CloudfrontDistributionTenantCustomizationsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected CloudfrontDistributionTenantCustomizationsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudfrontDistributionTenantCustomizationsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCertificate", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfrontDistributionTenant.CloudfrontDistributionTenantCustomizationsCertificate\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutCertificate(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.CloudfrontDistributionTenant.ICloudfrontDistributionTenantCustomizationsCertificate[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.CloudfrontDistributionTenant.ICloudfrontDistributionTenantCustomizationsCertificate).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.CloudfrontDistributionTenant.ICloudfrontDistributionTenantCustomizationsCertificate).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putGeoRestriction", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfrontDistributionTenant.CloudfrontDistributionTenantCustomizationsGeoRestriction\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutGeoRestriction(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.CloudfrontDistributionTenant.ICloudfrontDistributionTenantCustomizationsGeoRestriction[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.CloudfrontDistributionTenant.ICloudfrontDistributionTenantCustomizationsGeoRestriction).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.CloudfrontDistributionTenant.ICloudfrontDistributionTenantCustomizationsGeoRestriction).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putWebAcl", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfrontDistributionTenant.CloudfrontDistributionTenantCustomizationsWebAcl\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutWebAcl(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.CloudfrontDistributionTenant.ICloudfrontDistributionTenantCustomizationsWebAcl[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.CloudfrontDistributionTenant.ICloudfrontDistributionTenantCustomizationsWebAcl).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.CloudfrontDistributionTenant.ICloudfrontDistributionTenantCustomizationsWebAcl).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCertificate")]
        public virtual void ResetCertificate()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGeoRestriction")]
        public virtual void ResetGeoRestriction()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWebAcl")]
        public virtual void ResetWebAcl()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "certificate", typeJson: "{\"fqn\":\"aws.cloudfrontDistributionTenant.CloudfrontDistributionTenantCustomizationsCertificateList\"}")]
        public virtual aws.CloudfrontDistributionTenant.CloudfrontDistributionTenantCustomizationsCertificateList Certificate
        {
            get => GetInstanceProperty<aws.CloudfrontDistributionTenant.CloudfrontDistributionTenantCustomizationsCertificateList>()!;
        }

        [JsiiProperty(name: "geoRestriction", typeJson: "{\"fqn\":\"aws.cloudfrontDistributionTenant.CloudfrontDistributionTenantCustomizationsGeoRestrictionList\"}")]
        public virtual aws.CloudfrontDistributionTenant.CloudfrontDistributionTenantCustomizationsGeoRestrictionList GeoRestriction
        {
            get => GetInstanceProperty<aws.CloudfrontDistributionTenant.CloudfrontDistributionTenantCustomizationsGeoRestrictionList>()!;
        }

        [JsiiProperty(name: "webAcl", typeJson: "{\"fqn\":\"aws.cloudfrontDistributionTenant.CloudfrontDistributionTenantCustomizationsWebAclList\"}")]
        public virtual aws.CloudfrontDistributionTenant.CloudfrontDistributionTenantCustomizationsWebAclList WebAcl
        {
            get => GetInstanceProperty<aws.CloudfrontDistributionTenant.CloudfrontDistributionTenantCustomizationsWebAclList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "certificateInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfrontDistributionTenant.CloudfrontDistributionTenantCustomizationsCertificate\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? CertificateInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "geoRestrictionInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfrontDistributionTenant.CloudfrontDistributionTenantCustomizationsGeoRestriction\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? GeoRestrictionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "webAclInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfrontDistributionTenant.CloudfrontDistributionTenantCustomizationsWebAcl\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? WebAclInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"aws.cloudfrontDistributionTenant.CloudfrontDistributionTenantCustomizations\"}]}}", isOptional: true)]
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
                        case aws.CloudfrontDistributionTenant.ICloudfrontDistributionTenantCustomizations cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.CloudfrontDistributionTenant.ICloudfrontDistributionTenantCustomizations).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
