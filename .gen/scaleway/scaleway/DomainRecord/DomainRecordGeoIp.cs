using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.DomainRecord
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "scaleway.domainRecord.DomainRecordGeoIp")]
    public class DomainRecordGeoIp : scaleway.DomainRecord.IDomainRecordGeoIp
    {
        private object _matches;

        /// <summary>matches block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/domain_record#matches DomainRecord#matches}
        /// </remarks>
        [JsiiProperty(name: "matches", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"scaleway.domainRecord.DomainRecordGeoIpMatches\"},\"kind\":\"array\"}}]}}")]
        public object Matches
        {
            get => _matches;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case scaleway.DomainRecord.IDomainRecordGeoIpMatches[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(scaleway.DomainRecord.IDomainRecordGeoIpMatches).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(scaleway.DomainRecord.IDomainRecordGeoIpMatches).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _matches = value;
            }
        }
    }
}
