# 5Types-LEAK-RATs-Sources
Including XwormV5.6T1, Quasar RAT, njRAT, CraxsRat-v6.8-7.4, RevengeRAT SOURCES.
# RAT Source Code Research Archive
> [!IMPORTANT]
> **The Unlicense applies only to original contributions authored by the
> repository maintainer. It does not apply to third-party source code.**  
[中文版本 / Chinese Version](./README_CN.md)

> [!WARNING]
> This repository may contain source code, files, documentation, or other
> materials associated with Remote Access Trojans (RATs), malware, and
> related offensive-security software.
>
> The repository is maintained for cybersecurity research, malware analysis,
> threat intelligence, detection engineering, education, and historical
> preservation.

---

## Purpose

The primary purposes of this repository include:

- Malware analysis
- Reverse engineering
- Threat intelligence research
- Detection engineering
- Incident response research
- YARA / Sigma / IOC development
- Network protocol analysis
- Malware family comparison
- Defensive cybersecurity education
- Historical preservation of malware-related technical material

This repository is **not intended to encourage, facilitate, or endorse
unauthorized access to computer systems or any other unlawful activity**.

Researchers should use isolated, controlled, and authorized environments when
analyzing potentially malicious software.

---

## Important Copyright Notice

The maintainer of this repository is **not necessarily the original author,
copyright holder, or licensor of third-party source code contained in or
referenced by this repository**.

Some third-party materials may have previously circulated publicly, including
materials reported to have been leaked, redistributed, archived, mirrored, or
otherwise disclosed by third parties.

The presence of such material in this repository does **not** constitute:

- A claim of ownership by the repository maintainer
- A transfer of copyright
- A grant of copyright
- A sublicense
- Permission to redistribute third-party copyrighted material
- Permission to commercially exploit third-party copyrighted material
- A representation that the original disclosure or redistribution was authorized

All copyrights, trademarks, patents, and other intellectual-property rights
associated with third-party materials remain with their respective owners.

If a third-party component contains its own copyright notice or license, that
notice or license governs that component.

---

## License Scope

### Maintainer-Owned Contributions

Unless otherwise stated, original materials authored by the maintainer of this
repository may be released under **The Unlicense**.

This may include, where applicable:

- Original research notes
- Original documentation
- Original analysis scripts
- Original detection rules
- Original YARA rules
- Original Sigma rules
- Original IOC collections compiled by the maintainer
- Original research utilities
- Original reverse-engineering notes
- Original defensive tooling

The Unlicense applies **only to material for which the maintainer owns the
necessary copyright or has sufficient legal authority to license**.

See the relevant license file for details.

---

### Third-Party Materials

**The Unlicense DOES NOT apply to third-party source code, binaries, assets,
documentation, trademarks, proprietary resources, or other third-party
materials unless explicitly stated otherwise by the lawful copyright holder.**

The maintainer does not claim the legal authority to relicense third-party
copyrighted material.

Nothing in this repository should be interpreted as granting permission by the
maintainer to:

- Copy
- Redistribute
- Sublicense
- Sell
- Commercialize
- Repackage
- Create derivative works from
- Otherwise exploit

third-party copyrighted materials.

Users must independently determine whether they possess the legal rights
necessary for their intended use.

---

## Security and Responsible Use

The repository is intended for legitimate activities such as defensive
security research and malware analysis.

Do not use material from this repository to perform unauthorized activities,
including but not limited to:

- Unauthorized access to computer systems
- Credential theft
- Data theft
- Unauthorized surveillance
- Unauthorized remote control
- Malware deployment
- Persistence on systems without authorization
- Destructive actions
- Extortion or ransomware activity
- Botnet operation
- Circumvention of security controls without authorization

Possession of source code or research material does not itself provide
authorization to access or interfere with any computer system.

Always obtain explicit authorization before performing security testing on
systems you do not personally own.

---

## Research Environment

Potentially malicious software should only be examined in appropriately
isolated environments.

Recommended precautions include:

- Dedicated virtual machines
- Network isolation
- Disposable snapshots
- No personal credentials
- No production accounts
- No sensitive files
- Restricted outbound networking
- Traffic monitoring
- Host-only or controlled laboratory networks

Do not execute unknown malware directly on production or personal systems.

---

## No Affiliation

Unless explicitly stated otherwise, this repository and its maintainer are not
affiliated with, sponsored by, endorsed by, or associated with the original
developers, vendors, operators, distributors, or copyright holders of any
third-party software represented here.

Product names, malware-family names, organization names, and trademarks are
used solely for identification, research, and documentation purposes.

---

## No Warranty

Materials authored by the maintainer are provided **"AS IS"**, without warranty
of any kind, express or implied.

The maintainer makes no representation regarding the accuracy, completeness,
safety, functionality, legality, or fitness for any particular purpose of
third-party materials.

Malware-related material may be:

- Incomplete
- Corrupted
- Modified
- Backdoored
- Misidentified
- Non-functional
- Dangerous
- Deliberately deceptive

Never assume that archived source code is safe merely because source code is
available.

---

## Legal Responsibility

Users are solely responsible for ensuring that their possession, downloading,
analysis, modification, compilation, execution, use, or redistribution of any
material complies with:

- Applicable copyright law
- Computer misuse / cybercrime law
- Export-control regulations
- Sanctions regulations
- Contractual obligations
- Software licenses
- Local laws and regulations

A research or educational purpose does not automatically override applicable
copyright or computer-security law.

---

## Copyright / Takedown Requests

If you are a copyright holder, original developer, authorized representative,
or other rights holder and believe that material contained in this repository
infringes your rights, please contact the repository maintainer.

Please provide sufficient information to identify:

1. The copyrighted work or protected material
2. The relevant file, directory, commit, or repository location
3. Your relationship to the rights holder
4. The nature of your request
5. A reliable method of contact

Legitimate requests will be reviewed in good faith.

Contact:

`<YOUR-CONTACT-EMAIL>`

---

## Repository Structure

A recommended repository layout is:

```text
.
├── README.md
├── README_CN.md
├── LICENSE-MAINTAINER
├── NOTICE.md
│
├── analysis/
│   └── Maintainer-authored research and analysis
│
├── detection/
│   ├── yara/
│   ├── sigma/
│   └── ioc/
│
├── tools/
│   └── Maintainer-authored research utilities
│
├── docs/
│   └── Research documentation
│
└── third_party/
    └── Third-party materials with separate copyright status
