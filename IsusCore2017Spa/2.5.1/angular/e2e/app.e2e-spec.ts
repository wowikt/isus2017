import { IsusCore2017SpaTemplatePage } from './app.po';

describe('abp-project-name-template App', function() {
  let page: IsusCore2017SpaTemplatePage;

  beforeEach(() => {
    page = new IsusCore2017SpaTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
