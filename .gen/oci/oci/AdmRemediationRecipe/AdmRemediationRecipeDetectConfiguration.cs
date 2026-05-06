using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.AdmRemediationRecipe
{
    [JsiiByValue(fqn: "oci.admRemediationRecipe.AdmRemediationRecipeDetectConfiguration")]
    public class AdmRemediationRecipeDetectConfiguration : oci.AdmRemediationRecipe.IAdmRemediationRecipeDetectConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/adm_remediation_recipe#exclusions AdmRemediationRecipe#exclusions}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "exclusions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Exclusions
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/adm_remediation_recipe#max_permissible_cvss_v2score AdmRemediationRecipe#max_permissible_cvss_v2score}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxPermissibleCvssV2Score", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxPermissibleCvssV2Score
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/adm_remediation_recipe#max_permissible_cvss_v3score AdmRemediationRecipe#max_permissible_cvss_v3score}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxPermissibleCvssV3Score", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxPermissibleCvssV3Score
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/adm_remediation_recipe#max_permissible_severity AdmRemediationRecipe#max_permissible_severity}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxPermissibleSeverity", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MaxPermissibleSeverity
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/adm_remediation_recipe#upgrade_policy AdmRemediationRecipe#upgrade_policy}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "upgradePolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? UpgradePolicy
        {
            get;
            set;
        }
    }
}
